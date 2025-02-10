
---------------- OMAR MOHAMED ---------------------------------------

/*Model Answer
Report Name : ModelExam
*/
CREATE OR ALTER PROCEDURE ModelAnswerEx 
    @ExamID INT,
    @StudentID INT
AS
BEGIN
    BEGIN TRY
        -- Ensure the procedure runs within a valid transaction scope
        BEGIN TRANSACTION;
        
        -- Select student answers and correct answers
        SELECT 
            sa.Exam_ID,
            sa.S_Id,
            q.Q_Title,
            MAX(qa.answer) AS StudentAnswer, 
            MAX(qc.answer) AS ModelAnswer
        FROM Question q 
        INNER JOIN Question_Choices qa 
            ON q.Q_Id = qa.Q_Id
        INNER JOIN StudenAnswer sa 
            ON sa.QID = qa.Q_id AND sa.S_Anwer = qa.Choice_Num
        INNER JOIN Question_Choices qc 
            ON sa.QID = qc.Q_Id AND sa.C_Answer = qc.Choice_Num
        WHERE sa.Exam_ID = @ExamID 
          AND sa.S_Id = @StudentID 
        GROUP BY sa.Exam_ID, q.Q_Title, sa.S_Id;
        
        -- Commit transaction if successful
        COMMIT TRANSACTION;
    END TRY  
    BEGIN CATCH
        -- Rollback transaction in case of error
        ROLLBACK TRANSACTION;
        
        -- Return error details
        DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT;
        SELECT @ErrorMessage = ERROR_MESSAGE(), 
               @ErrorSeverity = ERROR_SEVERITY(), 
               @ErrorState = ERROR_STATE();
        
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH;
END;
GO


ModelAnswerEx  @ExamID = 9, @StudentID = 117

----------------------------------------------------------
CREATE OR ALTER PROCEDURE CalTotalGradeForExam 
    @exID INT
AS
BEGIN
    UPDATE Exam
    SET E_Total_Score = ISNULL((
        SELECT SUM(Q.Q_Grade) 
        FROM Exam_Question EQ
        INNER JOIN Question Q ON EQ.Q_Id = Q.Q_Id
        WHERE EQ.E_Id = @exID
    ), 0)
    WHERE E_Id = @exID;
END;
GO


exec GetStudentsByBranchTrackCourseExamToGetGrades   @B_id = 1, @T_id=1,  @C_id=1 ,  @E_id=1;

CREATE OR ALTER PROCEDURE GetStudentsByBranchTrackCourseExamToGetGrades
    @B_id INT,
    @T_id INT,
    @C_id INT,
    @E_id INT
AS
BEGIN
    -- First, update the total exam score using CalTotalGrade procedure
    EXEC CalTotalGradeForExam @E_id;

    -- Retrieve student grades for the given exam
    SELECT 
        S.ST_Id,  
        S.F_Name,
        S.L_Name,
        E.E_Name,
        -- Use COALESCE to handle NULL Total Score
        COALESCE(E.E_Total_Score, 0) AS E_Total_Score,
        -- Use COALESCE to handle NULL Final Grade
        COALESCE(SUM(
            CASE 
                WHEN SA.S_Anwer = SA.C_Answer THEN Q.Q_Grade 
                ELSE 0 
            END
        ), 0) AS Final_Grade
    FROM Student S
    LEFT JOIN Course_Student CS ON CS.St_Id = S.St_Id  
    LEFT JOIN Track_Course TC ON TC.C_Id = CS.C_Id  
    LEFT JOIN Branch_Track BT ON BT.T_Id = TC.T_Id  
    LEFT JOIN Student_Exam SE ON SE.St_Id = S.St_Id AND SE.E_Id = @E_id
    LEFT JOIN Exam E ON E.E_Id = @E_id
    LEFT JOIN StudenAnswer SA ON SA.Exam_ID = @E_id AND SA.S_Id = S.St_Id
    LEFT JOIN Question Q ON Q.Q_Id = SA.QID
    WHERE BT.B_Id = @B_id 
      AND TC.T_Id = @T_id 
      AND TC.C_Id = @C_id
    GROUP BY S.ST_Id, S.F_Name, S.L_Name, E.E_Name, E.E_Total_Score;
END;
GO

------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE GetStudentsByInstructorTrackCourseExamToGetGrades
    @E_id INT
AS
BEGIN
 
    EXEC CalTotalGradeForExam @E_id;


   	Select  Top 1
	 S.ST_Id,  
        S.F_Name,
        S.L_Name,
        E.E_Name,
        COALESCE(E.E_Total_Score, 0) AS E_Total_Score,
        COALESCE(SE.Grade, 0) AS Final_Grade
	from Student s
	  INNER JOIN Course_Student CS ON CS.St_Id = S.St_Id  
	  INNER JOIN Track_Course TC ON TC.C_Id = CS.C_Id  
	  INNER JOIN Student_Exam SE ON SE.St_Id = S.St_Id AND SE.E_Id = @E_id
	  INNER JOIN StudenAnswer SA ON SA.Exam_ID = @E_id AND SA.S_Id = S.St_Id 
	  INNER JOIN Exam E ON E.E_Id = @E_id
	  INNER JOIN Question Q ON Q.Q_Id = SA.QID
	  
END;
GO



GetStudentsByInstructorTrackCourseExamToGetGrades   

    @E_id = 12
-------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE GetExamsForSpecificBranchTrackCourse
    @B_id INT,
    @T_id INT,
    @C_id INT
AS
BEGIN
    SELECT 
        E.E_Id,
        E.E_Name,
        E.E_Date,
        E.E_Total_Score
    FROM Exam E
    INNER JOIN Course_Exam CE ON E.E_Id = CE.E_Id  
    INNER JOIN Track_Course TC ON TC.C_Id = CE.C_Id  
    INNER JOIN Branch_Track BT ON BT.T_Id = TC.T_Id  
    WHERE BT.B_Id = @B_id 
      AND TC.T_Id = @T_id
      AND CE.C_Id = @C_id;

END;
GO


Exec GetAllExams;
--------------------------------------------------------------------
CREATE OR ALTER PROCEDURE GetExamsForSpecificInstructorTrackCourse
    @T_id INT,
    @C_id INT
AS
BEGIN   

SELECT 
        E.*,
		TC.*
    FROM Exam E
    INNER JOIN Course_Exam CE ON E.E_Id = CE.E_Id  
    INNER JOIN Track_Course TC ON TC.C_Id = CE.C_Id 
    INNER JOIN Instructor_EExam IE ON E.E_Id = IE.E_Id
    INNER JOIN Instructor_Track IT ON IT.Ins_Id = IE.Ins_Id AND IT.T_Id = @T_id
	where TC.C_Id = @C_id

END;
GO


   SELECT 
        E.*
    FROM Exam E
    INNER JOIN Course_Exam CE ON E.E_Id = CE.E_Id  
    INNER JOIN Track_Course TC ON TC.C_Id = CE.C_Id 
    INNER JOIN Instructor_EExam IE ON E.E_Id = IE.E_Id
    INNER JOIN Instructor_Track IT ON IT.Ins_Id = IE.Ins_Id AND IT.T_Id = TC.T_Id
    WHERE TC.T_Id = @T_id 
      AND TC.C_Id = @C_id
      AND IE.Ins_Id = @Ins_id;


GetExamsForSpecificInstructorTrackCourse
    @T_id = 210, -- 211
    @C_id = 1011,
	 @Ins_id = 29;--1012


----------------------------------------------------------------------

------------------------------------------------------------------------
-- Get Stuents by Course Id , Track Id And Branch Id
CREATE OR ALTER PROCEDURE GetStudentsByBranchTrackCourse
    @B_id INT,
    @T_id INT,
    @C_id INT
AS
BEGIN
    SELECT 
        S.ST_Id,  
        S.F_Name,
		S.L_Name,
        S.ST_Email
    FROM Student S
    INNER JOIN Course_Student CS ON CS.St_Id = S.St_Id  
    INNER JOIN Track_Course TC ON TC.C_Id = CS.C_Id  
    INNER JOIN Branch_Track BT ON BT.T_Id = TC.T_Id  
    WHERE BT.B_Id = @B_id 
      AND TC.T_Id = @T_id 
      AND TC.C_Id = @C_id;
END;
GO

exec GetStudentsByBranchTrackCourse

-- Get  Courses by Track Id And Branch Id
CREATE OR ALTER PROCEDURE GetCoursesByTrackIdAndBranchId
    @B_Id INT,
    @T_Id INT
AS
BEGIN
    SELECT 
        C.C_Id,  
        C.C_Name,
        C.C_Duration
    FROM Course C
    INNER JOIN Track_Course TC ON TC.C_Id = C.C_Id  
    INNER JOIN Branch_Track BT ON BT.T_Id = TC.T_Id  
    WHERE BT.B_Id = @B_Id AND TC.T_Id = @T_Id;  
END;
GO

GetCoursesByTrackIdAndBranchId @B_Id = 1,   @T_Id = 1;
------------------------------------------------------
CREATE OR ALTER PROCEDURE GetCoursesByTrackIdAndInsId
    @Ins_Id INT,
    @T_Id INT
AS
BEGIN
    SELECT 
        C.C_Id,  
        C.C_Name,
        C.C_Duration
    FROM Course C
    INNER JOIN Track_Course TC ON TC.C_Id = C.C_Id  
    INNER JOIN Instructor_Track IT ON IT.T_Id = TC.T_Id  
    WHERE IT.Ins_Id = @Ins_Id AND TC.T_Id = @T_Id;  
END;
GO

-----------------  Track  --------------------------

--Select all from Track --> Testing : done
CREATE or alter PROCEDURE online_Track_SelectAll
AS
  BEGIN
        SELECT * FROM Track
  END

Execute online_Track_SelectAll

-------------------------------------------------


----------------------------------------------

CREATE OR ALTER PROCEDURE GetInstructorCoursesByInsId
    @Ins_Id INT,
    @T_Id INT
AS
BEGIN
    SELECT C.C_Id, C.C_Name
    FROM Course C
    INNER JOIN Instructor_Course IC ON C.C_Id = IC.C_Id
    INNER JOIN Instructor_Track IT ON IC.Ins_Id = IT.Ins_Id 
    WHERE IC.Ins_Id = @Ins_Id 
    AND IT.T_Id = @T_Id; 
END;
GO



----------------------------------------------

--GetAllTracksByBranchId --> Testing : done
CREATE OR ALTER PROCEDURE GetAllTracksByBranchId
    @B_id INT
AS
BEGIN
    SELECT 
	*
    FROM Track T
    INNER JOIN Branch_Track BT ON T.T_Id = BT.T_Id
	INNER JOIN Branch B ON B.B_Id = BT.B_Id
    WHERE BT.B_Id = @B_id;
END;
GO

Execute GetAllTracksByBranchId   @B_id = 2;
-------------------------------------------------

CREATE OR ALTER PROCEDURE GetAllTracksByInsId
    @Ins_id INT
AS
BEGIN
    SELECT 
	*
    FROM Track T
    INNER JOIN Instructor_Track IT ON T.T_Id = IT.T_Id
	INNER JOIN Instructor I ON I.Ins_id = IT.Ins_Id
    WHERE IT.Ins_Id = @Ins_id;
END;
GO
-------------------------------------------------

CREATE OR ALTER PROCEDURE GetAllTracksWithCourses
AS
BEGIN
    SELECT 
        T.T_Name,
		T.T_Id,
        TC.C_Id	
    FROM Track T
    LEFT JOIN Track_Course TC ON T.T_Id = TC.T_Id;  
END;
GO

exec GetAllTracksWithCourses
-----------------------------------------------

--Select from Track depend on id --> Testing : done

CREATE PROCEDURE online_Track_SelectByTrackId
    @Track_Id INT = NULL
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Track WHERE T_Id = @Track_Id)
    BEGIN
        SELECT *
        FROM Track
        WHERE T_Id = @Track_Id
    END
    ELSE
    BEGIN
        SELECT 'This Track is Not Found' AS Message
    END
END

-- Found Test :
Execute online_Track_SelectByTrackId @Track_Id = 200
-- Not Found Test :
Execute online_Track_SelectByTrackId @Track_Id = 1

-----------------------------------------------------

--insert into Track --> Testing : done

CREATE OR ALTER PROCEDURE online_Track_Insert
    @T_name VARCHAR(100) 
AS
BEGIN
    BEGIN TRY
        INSERT INTO Track (T_Name)
        VALUES (@T_name); 

        SELECT 'Inserted completed successfully.' AS Message;
    END TRY
    BEGIN CATCH
        SELECT ERROR_MESSAGE() AS Message;
    END CATCH
END;


-- Test Case : Insert with a valid name
EXEC online_Track_Insert @T_name = 'New Cairo';


-----------------------------------------------------------

--Update Track --> Testing : done

CREATE OR ALTER PROCEDURE online_Track_Update
    @T_id INT = NULL,
    @T_name VARCHAR(100) = NULL
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Track WHERE T_id = @T_id)
    BEGIN
        UPDATE Track
        SET 
            T_name = COALESCE(@T_name, T_name)
        WHERE T_id = @T_id;

        SELECT 'Update completed successfully.' AS Message;
    END
    ELSE
    BEGIN
        SELECT 'This ID is not found.' AS Message;
    END
END;


EXEC online_Track_Update @T_id = 211, @T_name = 'omar';

-----------------------------------------------------------

--Delete from Track --> Testing : done
CREATE PROCEDURE online_Track_Delete
    @T_id INT = NULL
AS
BEGIN
    IF EXISTS (SELECT 1 FROM track WHERE T_id = @T_id)
    BEGIN
        DELETE FROM Track WHERE T_id = @T_id;
    END
    ELSE 
    BEGIN
        SELECT 'This Track is Not Found' AS Message;
    END
END

EXEC online_Track_Delete @T_id = 211;


-----------------------------------------------------------

---------------     Branch_Track     ----------------------

--select all from Branch_Track  --> Testing : done
CREATE PROCEDURE online_BranchTrack_SelectAll
AS
  BEGIN
       SELECT * FROM Branch_Track;
  END

Execute online_BranchTrack_SelectAll;

-----------------------------------------------------------

--Select from Branch_Track depend on id --> Testing : done
CREATE PROCEDURE online_BranchTrack_SelectByPK
    @B_id_fk INT = NULL,
    @T_id_fk INT = NULL
AS
BEGIN
    -- Check for NULL and existence of the provided values
    IF @B_id_fk IS NOT NULL AND @T_id_fk IS NOT NULL
    BEGIN
        IF EXISTS (SELECT 1 FROM branch_track t WHERE t.B_Id = @B_id_fk AND t.T_Id = @T_id_fk)
        BEGIN
            SELECT B_Id, T_Id
            FROM Branch_Track
            WHERE B_Id = @B_id_fk AND T_Id = @T_id_fk;
        END
        ELSE 
        BEGIN
            SELECT 'This Track is Not Found in This Branch' AS Message;
        END
    END
    ELSE
    BEGIN
        SELECT 'Invalid Input: Both B_id_fk and T_id_fk must be provided' AS Message;
    END
END


EXEC online_BranchTrack_SelectByPK @B_id_fk = 1, @T_id_fk = 200;


-----------------------------------------------------------

--Insert into Branch_Track --> Testing : done
 CREATE PROCEDURE online_BranchTrack_Insert
    @B_id_fk INT = NULL,
    @T_id_fk INT = NULL
AS
BEGIN
    BEGIN TRY
        IF NOT EXISTS (SELECT T_id FROM track WHERE T_id = @T_id_fk)
        BEGIN
            SELECT 'This Track Does Not Exist.' AS Message;
        END
        ELSE IF NOT EXISTS (SELECT B_id FROM branch WHERE B_id = @B_id_fk)
        BEGIN
            SELECT 'This Branch Does Not Exist.' AS Message;
        END
        ELSE IF EXISTS (SELECT 1 FROM branch_track WHERE T_id = @T_id_fk AND B_id = @B_id_fk)
        BEGIN
            SELECT 'This Record Already Exists.' AS Message;
        END
        ELSE
        BEGIN
            -- Insert the new record
            INSERT INTO branch_track (B_id, T_id)
            VALUES (@B_id_fk, @T_id_fk);
            
            SELECT 'Inserted successfully.' AS Message;
        END
    END TRY
    BEGIN CATCH
        -- Handle errors
        SELECT ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END

 EXEC online_BranchTrack_Insert @B_id_fk = 5, @T_id_fk = 205;  


-----------------------------------------------------------

--Update Branch_Track --> Testing : done

CREATE PROCEDURE online_BranchTrack_Update
    @B_id_fk INT = NULL,
    @T_id_fk INT = NULL,
    @new_B_id_fk INT = NULL,
    @new_T_id_fk INT = NULL
AS
BEGIN
    -- Check if the new Track exists
    IF NOT EXISTS (SELECT T_id FROM track WHERE T_id = @new_T_id_fk)
    BEGIN
        SELECT 'This Track Does Not Exist.' AS Message;
    END
    -- Check if the new Branch exists
    ELSE IF NOT EXISTS (SELECT B_id FROM branch WHERE B_id = @new_B_id_fk)
    BEGIN
        SELECT 'This Branch Does Not Exist.' AS Message;
    END
    -- Check if the provided B_id_fk and T_id_fk exist in the branch_track table
    ELSE IF EXISTS (SELECT 1 FROM branch_track WHERE B_id = @B_id_fk AND T_id = @T_id_fk)
    BEGIN
        -- Update the branch_track record
        UPDATE branch_track
        SET 
            B_id = COALESCE(@new_B_id_fk, B_id),
            T_id = COALESCE(@new_T_id_fk, T_id)
        WHERE B_id = @B_id_fk AND T_id = @T_id_fk;

        SELECT 'Update completed successfully.' AS Message;
    END
    ELSE
    BEGIN
        -- If the original B_id_fk and T_id_fk do not exist in the branch_track table
        SELECT 'This id is not exist.' AS Message;
    END
END


EXEC online_BranchTrack_Update @B_id_fk = 1, @T_id_fk = 200, @new_B_id_fk = 9999, @new_T_id_fk = 200;


-----------------------------------------------------------

--Delete from Branch_Track --> Testing : done
CREATE PROCEDURE online_TrackBranch_Delete
    @B_id_fk INT = NULL,
    @T_id_fk INT = NULL
AS
BEGIN
    -- Check if the combination of B_id_fk and T_id_fk exists in the branch_track table
    IF EXISTS (SELECT 1 FROM branch_track WHERE B_id = @B_id_fk AND T_id = @T_id_fk)
    BEGIN
        -- Delete the record from branch_track
        DELETE FROM Branch_Track
        WHERE B_id = @B_id_fk AND T_id = @T_id_fk;
        
        SELECT 'Record deleted successfully.' AS Message;
    END
    ELSE
    BEGIN
        -- Return a message if the record does not exist
        SELECT 'This Track Does Not Exist in This Branch.' AS Message;
    END
END



EXEC online_TrackBranch_Delete @B_id_fk = 5, @T_id_fk = 205;


-----------------------------------------------------------

----------------- Student_Phone --------------------------

-- Select all from student_phone --> Testing : done

CREATE PROCEDURE online_GetAllStudentsphones
AS
BEGIN
    SELECT * FROM student_phone;
END;

Execute online_GetAllStudentsphones;

-----------------------------------------------------------

--Select Student_phone based on Student Id --> Testing : done

CREATE PROCEDURE online_GetStudentPhoneById 
    @id INT
AS
BEGIN
    IF @id IS NOT NULL AND EXISTS (SELECT 1 FROM student_phone WHERE st_id = @id)
    BEGIN
        SELECT * FROM student_phone WHERE st_id = @id;
    END
    ELSE 
    BEGIN
        SELECT NULL AS st_id, NULL AS phone, 'This Id Not Found' AS message;
    END
END;


EXEC online_GetStudentPhoneById @id = 101;


-----------------------------------------------------------

-- Insert into student_phone --> Testing : done

CREATE PROCEDURE InsertIntoStudentPhone 
    @phone INT, 
    @id INT
AS
BEGIN
    IF @id IS NOT NULL AND EXISTS (SELECT 1 FROM student WHERE st_id = @id)
    BEGIN
        INSERT INTO student_phone (st_id, St_Phone)
        VALUES (@id, @phone);
        
        SELECT 'Phone number added successfully.' AS Message;
    END
    ELSE 
    BEGIN
        SELECT 'This Student Does Not Exist.' AS Message;
    END
END;


EXEC InsertIntoStudentPhone @phone = 10822, @id = 101;

 

 -----------------------------------------------------------


--Update Student_phone --> Testing : done

CREATE PROCEDURE updateStudentPhone
    @st_id INT, 
    @newphone INT
AS
BEGIN
    IF EXISTS (SELECT st_id FROM student_phone WHERE st_id = @st_id)
    BEGIN
        UPDATE student_phone
        SET St_Phone = @newphone
        WHERE st_id = @st_id;

        SELECT 'Phone number updated successfully.' AS ResultMessage;
    END
    ELSE 
    BEGIN
        SELECT 'Invalid ID' AS ResultMessage;
    END
END;

EXEC updateStudentPhone @st_id = 103, @newphone = 987654 ;



-----------------------------------------------------------


--Delete from Student_Phone  --> Testing : done

CREATE PROCEDURE deleteStudentPhone 
    @id INT
AS
BEGIN
    IF @id IS NOT NULL AND EXISTS (SELECT 1 FROM student_phone WHERE st_id = @id)
    BEGIN
        DELETE FROM student_phone
        WHERE st_id = @id;

        SELECT 'Phone number deleted successfully.' AS ResultMessage;
    END
    ELSE 
    BEGIN
        SELECT 'Cannot delete invalid ID.' AS ResultMessage;
    END
END;


Execute deleteStudentPhone   @id = 101;


-------------------------------------------------------------------------------------------------

--Exam

Create or Alter PROC GetAllExamsWithDetails
AS
BEGIN
   Select E_Name,E_Total_Score,E_Duration,E_Date from Exam
   
END;
GO

Exec GetAllExamsWithDetails

-- InsertExam

CREATE OR ALTER PROCEDURE InsertExam
(
    @E_Name        VARCHAR(20),
    @E_Total_Score INT,
    @E_Duration    FLOAT,
    @E_Date        DATE,
    @Ins_Id        INT  ,
	@C_Id          INT,
	@T_Id          INT
)
AS
BEGIN
    DECLARE @NewExamID INT;   

 
    INSERT INTO Exam (E_Name, E_Total_Score, E_Duration, E_Date)
    VALUES (@E_Name, @E_Total_Score, @E_Duration, @E_Date);

    SET @NewExamID = SCOPE_IDENTITY();  

  
    INSERT INTO Instructor_EExam (Ins_Id, E_Id)  
    VALUES (@Ins_Id, @NewExamID); 

	INSERT INTO  Course_Exam 
    VALUES (@C_Id, @NewExamID); 


	INSERT INTO  Exam_Track 
    VALUES (@NewExamID,@T_Id); 
	 



    SELECT @NewExamID AS NewExamID;  
END;
GO


 
-----------------------------------------------------------------

--UpdateExam
Create or Alter PROC UpdateExam
(
    @E_Id          INT,
    @E_Name        VARCHAR(20),
    @E_Total_Score INT,
    @E_Duration    FLOAT,
    @E_Date        DATE
)
AS
BEGIN
    UPDATE Exam
    SET E_Name        = @E_Name,
        E_Total_Score = @E_Total_Score,
        E_Duration    = @E_Duration,
        E_Date        = @E_Date
    WHERE E_Id = @E_Id;
END;
GO


---- test
EXEC UpdateExam 
    @E_Id          = 1,
    @E_Name        = 'Updated Exam Name',
    @E_Total_Score = 100,
    @E_Duration    = 2.0,
    @E_Date        = '2025-03-01';


---------------------

--DeleteExam

Create or Alter PROC DeleteExam
(
    @E_Id INT
)
AS
BEGIN
    -- If you have dependent records in Exam_Question or other tables,
    -- either delete them first or rely on cascading constraints.

    DELETE FROM Exam
    WHERE E_Id = @E_Id;
END;
GO

-- test

EXEC DeleteExam @E_Id = 1;

--------------------------


-- Instructor 

-- Get All Instructors
CREATE OR ALTER PROCEDURE GetAllInstructors
AS
BEGIN
    SELECT 
	I.Ins_Id,
        I.F_Name,
        I.L_Name,
        I.Ins_Age,
        I.Ins_Email,
		IPH.Ins_Phone,
        I.Ins_Address,
        I.Ins_Gender,
        I.Ins_DOB,
        I.Ins_Salary
    FROM Instructor I
	Join Instructor_Phone IPh ON IPh.Ins_Id = I.Ins_Id
END;
GO

-- test 
EXEC GetAllInstructors;

---------------------------

-- Get All Instructors With Courses 
CREATE OR ALTER PROCEDURE GetAllInstructorsWithCourses
AS
BEGIN
    SELECT 
        I.Ins_Id,
        I.F_Name,
        I.L_Name,
        C.C_Name AS Course_Name
    FROM Instructor I
    -- Using LEFT JOIN to include all instructors, even those without courses
    LEFT JOIN Instructor_Course IC ON I.Ins_Id = IC.Ins_Id
    LEFT JOIN Course C ON IC.C_Id = C.C_Id;
END;
GO


exec GetAllInstructorsWithCourses
--------------------------------------------

-- Get Instructor Courses by Ins_Id
CREATE OR ALTER PROCEDURE GetInstructorCoursesByInsId
    @ins_Id INT
AS
BEGIN
    SELECT 
        I.Ins_Id,
        I.F_Name,
        I.L_Name,
        C.C_Id,  
        C.C_Name
    FROM Instructor I
    INNER JOIN Instructor_Course IC ON I.Ins_Id = IC.Ins_Id
    INNER JOIN Course C ON IC.C_Id = C.C_Id  
    WHERE I.Ins_Id = @ins_Id;
END;
GO


EXEC GetInstructorCoursesByInsId @ins_Id = 1;


--------------------------------------------


--------------------------------------------

-- Get All Instructors With Branches 
CREATE OR ALTER PROCEDURE GetAllInstructorsWithBranches
AS
BEGIN
    SELECT 
        I.Ins_Id,
        I.F_Name,
        I.L_Name,
        B.B_Name AS [Branch Name]
    FROM Instructor I
    INNER JOIN Branch_Instructor IB ON I.Ins_Id = IB.Ins_Id
    INNER JOIN Branch B ON IB.B_Id = B.B_Id;
END;
GO

exec GetAllInstructorsWithBranches
--------------------------------------------



-- Insert
CREATE OR ALTER PROCEDURE InsertInstructor
(
    @F_Name     VARCHAR(20),
    @L_Name     VARCHAR(20),
    @Ins_Age    INT,
    @Ins_Email  VARCHAR(30),
    @Ins_Address VARCHAR(50),
    @Ins_Gender VARCHAR(6),
    @Ins_DOB    DATE,
    @Ins_Salary DECIMAL(10,2),
    @B_id       INT,
    @Phone      INT,
	@T_Id       INT
)
AS
BEGIN
    DECLARE @NewInstructorID INT; 

    INSERT INTO Instructor 
    (
        F_Name,
        L_Name,
        Ins_Age,
        Ins_Email,
        Ins_Address,
        Ins_Gender,
        Ins_DOB,
        Ins_Salary
    )
    VALUES
    (
        @F_Name,
        @L_Name,
        @Ins_Age,
        @Ins_Email,
        @Ins_Address,
        @Ins_Gender,
        @Ins_DOB,
        @Ins_Salary
    );

    SET @NewInstructorID = SCOPE_IDENTITY(); -- Get the new Instructor ID

    -- Insert into Branch_Instructor (Assuming columns are Branch_Id and Instructor_Id)
    INSERT INTO Branch_Instructor (B_Id, Ins_Id)
    VALUES (@B_id, @NewInstructorID);

    -- Insert into Instructor_Phone (Assuming columns are Ins_Id and Phone)
    INSERT INTO Instructor_Phone 
    VALUES (@NewInstructorID, @Phone);

	
	 INSERT INTO Instructor_Track 
    VALUES (@NewInstructorID, @T_Id);

    -- Return the new Instructor ID
    SELECT @NewInstructorID AS NewInstructorID;
END;
GO



-------------------------------------------------

-- Update
CREATE OR ALTER PROCEDURE UpdateInstructor
(
    @Ins_Id     INT,
    @F_Name     VARCHAR(20),
    @L_Name     VARCHAR(20),
    @Ins_Age    INT,
    @Ins_Email  VARCHAR(30),
    @Ins_Address VARCHAR(50),
    @Ins_Gender VARCHAR(6),
    @Ins_DOB    DATE,
    @Ins_Salary DECIMAL(10,2)
)
AS
BEGIN
    UPDATE Instructor
    SET 
        F_Name     = @F_Name,
        L_Name     = @L_Name,
        Ins_Age    = @Ins_Age,
        Ins_Email  = @Ins_Email,
        Ins_Address= @Ins_Address,
        Ins_Gender = @Ins_Gender,
        Ins_DOB    = @Ins_DOB,
        Ins_Salary = @Ins_Salary
    WHERE Ins_Id = @Ins_Id;
END;
GO


---------------------------
---- Delete

CREATE OR ALTER PROCEDURE DeleteInstructor
(
    @Ins_Id INT
)
AS
BEGIN
    DELETE FROM Instructor
    WHERE Ins_Id = @Ins_Id;
END;
GO



-------------- Ahmed Helmy ---------

----------InstructorTeachCourse--------------
CREATE PROCEDURE SelectAllInstructorTeachCourse
as
BEGIN
    SELECT * FROM Instructor_Course;
END;



CREATE PROCEDURE SelectInstructorTeachCourseById @instructorId INT
as
BEGIN
    SELECT * FROM Instructor_Course WHERE Ins_Id = @instructorId;
END;




CREATE PROCEDURE InsertInstructorTeachCourse @instructorId INT,  @courseId INT
as
BEGIN
    INSERT INTO Instructor_Course (Ins_Id, C_Id) VALUES (@instructorId, @courseId);
END;




CREATE PROCEDURE UpdateInstructorTeachCourse @oldInstructorId INT,  @oldCourseId INT,  @newInstructorId INT,  @newCourseId INT
as
BEGIN
    UPDATE Instructor_Course 
    SET Ins_Id = @newInstructorId, C_Id = @newCourseId
    WHERE Ins_Id = @oldInstructorId AND C_Id = @oldCourseId;
END;




CREATE PROCEDURE DeleteInstructorTeachCourse @instructorId INT,  @courseId INT
as
BEGIN
    IF EXISTS (SELECT 1 FROM Instructor_Course WHERE Ins_Id = @instructorId AND C_Id = @courseId)
    BEGIN
        DELETE FROM Instructor_Course WHERE Ins_Id = @instructorId AND C_Id = @courseId;
    END
    ELSE 
    BEGIN
        SELECT 'This instructor who give that course is Not Found' AS Message;
    END
    
END;


-------------------------------------------------------------------------------------


-------------------------Student---------------------------

CREATE or Alter PROCEDURE SelectAllStudents
as
BEGIN
    SELECT St_Id,F_Name,L_Name,St_Email,St_Gender,Track_Id,St_DOB,St_Address FROM Student;
END;


exec  SelectAllStudents

select * from Student



CREATE PROCEDURE SelectStudentById @studentId INT
as
BEGIN

    SELECT * FROM Student WHERE St_Id = @studentId;
END;




CREATE OR ALTER PROCEDURE InsertStudent 
    @fName VARCHAR(20),
    @lName VARCHAR(20),
    @email VARCHAR(40),
    @trackId INT, 
    @dob DATE, 
    @address VARCHAR(40),
    @gender VARCHAR(6),
    @Phone INT
AS
BEGIN
    DECLARE @NewStudentID INT;  

    
    INSERT INTO Student (F_Name, L_Name, St_Email, Track_Id, St_DOB, St_Address, St_Gender)
    VALUES (@fName, @lName, @email, @trackId, @dob, @address, @gender);
 
    SET @NewStudentID = SCOPE_IDENTITY(); 

     
    INSERT INTO Student_Phone 
    VALUES (@NewStudentID, @Phone);

     
    SELECT @NewStudentID AS NewStudentID;
END;
GO






CREATE PROCEDURE UpdateStudent @studentId INT, @fName VARCHAR(20), @lName VARCHAR(20), @email VARCHAR(40), @trackId INT, @dob DATE, @address VARCHAR(40), @gender VARCHAR(6)
as
BEGIN
    UPDATE Student
    SET F_Name = @fName, L_Name = @lName, St_Email = @email, Track_Id = @trackId, St_DOB = @dob, St_Address = @address, St_Gender = @gender
    WHERE St_Id = @studentId;
END;




CREATE PROCEDURE DeleteStudent @studentId INT
as
BEGIN
    IF EXISTS (SELECT 1 FROM Student WHERE St_Id = @studentId)
    BEGIN
        DELETE FROM Student WHERE St_Id = @studentId;
    END
    ELSE 
    BEGIN
        SELECT 'This student is Not Found' AS Message;
    END
END;





-- Student
-- Get All Students With Courses
CREATE OR ALTER PROCEDURE GetAllStudentsWithCourses
AS
BEGIN
    SELECT 
        S.St_Id,
        S.F_Name,
        S.L_Name,
        C.C_Name AS [Course Name]
    FROM Student S
    -- LEFT JOIN ensures students with no courses are also included
    LEFT JOIN Course_Student CS ON S.St_Id = CS.St_Id
    LEFT JOIN Course C ON CS.C_Id = C.C_Id;
END;
GO


exec GetAllStudentsWithCourses



-------------------------------


-- Insert Student With Courses
CREATE OR ALTER PROCEDURE InsertStudentsWithCourse
    @St_Id INT,
    @C_Id INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Course_Student WHERE St_Id = @St_Id AND C_Id = @C_Id)
    BEGIN
        INSERT INTO Course_Student (St_Id, C_Id)  
        VALUES (@St_Id, @C_Id);
    END
    ELSE
    BEGIN
        PRINT 'Student is already enrolled in this course.';
    END
END;
GO


exec InsertStudentsWithCourse


 


------------------------------------------------------------------------
-------------------------------------Branch ----------------------------------

CREATE or alter PROCEDURE SelectAllBranches
as
BEGIN
    SELECT B_Id,B_Name,B_Phone,B_Location FROM Branch;
END;


exec SelectAllBranches

select * from Branch

CREATE PROCEDURE SelectBranchById @branchId INT
as
BEGIN
    SELECT * FROM Branch WHERE B_Id = @branchId;
END;




CREATE PROCEDURE InsertBranch @name VARCHAR(20), @location VARCHAR(20), @phone INT
as
BEGIN
    INSERT INTO Branch (B_Name, B_Location, B_Phone) VALUES (@name, @location, @phone);
END;


 


CREATE PROCEDURE UpdateBranch @branchId INT, @name VARCHAR(20), @location VARCHAR(20), @phone INT
as
BEGIN
    UPDATE Branch
    SET B_Name = @name, B_Location = @location, B_Phone = @phone
    WHERE B_Id = @branchId;
END;






-- Delete from Branch
CREATE PROCEDURE DeleteBranch @branchId INT
as
BEGIN
    IF EXISTS (SELECT 1 from Branch WHERE B_Id = @branchId)
    BEGIN
        DELETE FROM Branch WHERE B_Id = @branchId;
    END
    ELSE 
    BEGIN
        SELECT 'This branch is Not Found' AS Message;
    END
END;



----------------------------------------------------------------
--------------------------------Branch_Phone---------------------


CREATE PROCEDURE SelectAllBranchPhones
as
BEGIN
    SELECT * FROM Branch_Phone;
END;




CREATE PROCEDURE SelectBranchPhoneById @branchId INT
as
BEGIN
    SELECT * FROM Branch_Phone WHERE B_Id = @branchId;
END;




CREATE PROCEDURE InsertBranchPhone @branchId INT, @phone INT
as
BEGIN
    INSERT INTO Branch_Phone (B_Id, B_Phone) VALUES (@branchId, @phone);
END;




CREATE PROCEDURE DeleteBranchPhone @branchId INT, @phone INT
as
BEGIN
    IF EXISTS (SELECT 1 FROM DeleteBranchPhone WHERE B_Id = @branchId AND B_Phone = @phone)
    BEGIN
        DELETE FROM DeleteBranchPhone WHERE B_Id = @branchId AND B_Phone = @phone;
    END
    ELSE 
    BEGIN
        SELECT 'This phone is Not Found in this branch' AS Message;
    END
END;

-----------------------------------------------------------------------------------

--------------- Mahmoud Sherif ----------------------------------------------------

/*instructor procedures*/
/*Select*/
create proc selectinstructor
@id int 
as
begin
if not exists(select i.Ins_Id from Instructor i where i.Ins_Id=@id)
begin
print 'Instructor not found'
return;
end
select *from Instructor i where i.Ins_Id=@id;
end;

 


 
 

/*update*/
create proc updateinstructor
@ins_id int,
@f_name varchar(50),
@l_name varchar(50),
@ins_email varchar(100),
@ins_salary decimal(10,2)
as
begin
if not exists(select i.Ins_Id from Instructor i where i.Ins_Id=@ins_id)
begin
print 'Instructor not found'
return;
end
update  Instructor 
set
F_Name=@f_name,
L_Name=@l_name,
Ins_Email=@ins_email,
Ins_Salary=@ins_salary
where Ins_Id=@ins_id;
end;

 

/*Delete*/
create or Alter proc deleteinstructor
@ins_id int
as
begin
if Not EXISTS(
select *from Instructor_Course c where c.Ins_Id=@ins_id
) and Not EXISTS(
select * from Track_Instructor t where t.Ins_Id=@ins_id
)
and Not EXISTS(
select * from Branch_Instructor b where b.Ins_Id=@ins_id
)
begin
delete from Instructor 
where Ins_Id=@ins_id;
end
    else
    begin
        PRINT 'Instructor cannot be deleted because they are associated with a Branch or Track or Teaching a Course.';
    end
end;

 
/*##################################################*/
/*instructor_Workson procedures*/

/*Select*/
create proc selectworkon 
@id int
as
begin
if exists(
select *from Track_Instructor t 
where t.Ins_Id=@id
)
begin
select *from Track_Instructor t 
where t.Ins_Id=@id
end
else 
begin
print 'Instructor not exist ...!'
end
end;

 

exec selectworkon @id=10
exec selectworkon @id=30

/*insert*/
create proc insertTrackInstructor
@Ins_Id int,
@T_Id int
as
begin
insert into Track_Instructor (T_Id,Ins_Id)values(@T_Id,@Ins_Id)
end


 

exec inserttworkon
@TID=209,
@id=25


/*update*/
create proc updateworkon
@id int,
@I_ID int
as
begin
if not exists(
select *from Track_Instructor t 
where t.Ins_Id=@id
)
begin
print 'Instructor not exist ...!'
end

update  Track_Instructor 
set 
T_Id=@I_ID
where Ins_Id=@id

end

 
exec updateworkon
@I_ID=209,
@id=10

 

/*delete*/
create proc deleteworkon
@id int
as
begin
delete from Track_Instructor 
where Ins_Id=@id;
end

 

exec deleteworkon 
@id=5


-- Branch Instructor


CREATE OR ALTER PROCEDURE insertBranchInstructor
  @B_Id INT,
   @Ins_Id INT
AS
BEGIN
    BEGIN TRY
       
        INSERT INTO Branch_Instructor (B_Id, Ins_Id)
        VALUES (@B_Id, @Ins_Id)

        PRINT 'Instructor successfully assigned to branch.'
    END TRY
    BEGIN CATCH
        
        PRINT 'Error: ' + ERROR_MESSAGE()
    END CATCH
END
GO

-- Instructor Course

CREATE OR ALTER PROCEDURE insertInstructorCourse
@Ins_Id INT,
 @C_Id INT
AS
BEGIN
    BEGIN TRY
        -- Insert instructor into the Track
        INSERT INTO Instructor_Course(Ins_Id, C_Id)
        VALUES (@Ins_Id, @C_Id)

        PRINT 'Instructor successfully assigned to Course.'
    END TRY
    BEGIN CATCH
 
        PRINT 'Error: ' + ERROR_MESSAGE()
    END CATCH
END
GO



/*#############################*/
/*Course*/
-- Get All Courses
create or alter proc GetAllCourses
as
	begin
		select C_Name,C_Duration from Course
	End
Go

Exec GetAllCourses

---------------------
/*Course*/
-- Get All Courses with Tracks
CREATE OR ALTER PROCEDURE GetAllCoursesWithTracks
AS
BEGIN
    SELECT 
        C.C_Name, 
        C.C_Duration, 
		C.C_Id,
        TC.T_Id	
    FROM Course C
    LEFT JOIN Track_Course TC ON C.C_Id = TC.C_Id;  
END;
GO

exec GetAllCoursesWithTracks


/*select*/
create proc selectcourse 
@C_ID int
as
begin
if not exists(
select * from Course c
where c.C_Id=@C_ID
)
begin
print 'Course not found ...!'
return;
end
select * from Course c
where c.C_Id=@C_ID;
end

 
 

 /*insert*/
CREATE OR ALTER PROCEDURE insertcourse
    @C_Name VARCHAR(50),
    @C_Duration VARCHAR(50)
AS
BEGIN
    -- Check if the course name already exists
    IF EXISTS (SELECT 1 FROM Course c WHERE c.C_Name = @C_Name)
    BEGIN
        PRINT 'This course name already exists...!'
        RETURN;
    END

    -- Insert the new course
    INSERT INTO Course (C_Name, C_Duration)
    VALUES (@C_Name, @C_Duration)
END
GO


 exec insertcourse "Angular",15


 /*update*/
 create proc updatecourse
 @id int,
 @C_Name varchar(50),
 @C_Duration varchar(50)
 as
 begin
  if not exists
 (select c.C_Id from Course c
 where c.C_Id=@id)
 begin
 print 'Thid id  not exist...!'
 return;
 end
 update Course set
 C_Name=@C_Name,
 C_Duration=@C_Duration
 where C_Id=@id
 end


 

 /*delete*/


 create proc deletecourse 
 @id int
 as
 begin
 if  exists(
 select s.C_Id  from Course_Student s
 where s.C_Id=@id
 )
 begin
 print 'Course you want to delete is learned by students..!'
 return;
 end
  if  exists(
 select s.C_Id  from Instructor_Course s
 where s.C_Id=@id
 )
  begin
 print 'Course you want to delete is teached by instructors..!'
 return;
 end
   if  exists(
 select s.C_Id  from Track_Course s

 where s.C_Id=@id
 )
   begin
 print 'Course you want to delete exist in track..!'
 return;
 end
 delete from Course 
 where C_Id=@id
 end

 

 exec deletecourse
 @id=1013

 /*#############################*/
/*CourseHasTrack*/
/*select*/
create proc Track_course_SelctByID
@id int
as
begin
if not exists(
select t.C_Id from Track_Course t
where C_Id=@id
)
begin 
print 'Course not exist in track..!'
return;
end
select * from Track_Course t
where t.C_Id=@id
end

 

 ------------------------

CREATE OR ALTER PROC insertTrackCourse
@T_Id INT,
@C_Id INT,
@Ins_Id INT
AS
BEGIN
    -- Check if Course exists
    IF NOT EXISTS (SELECT 1 FROM Course WHERE C_Id = @C_Id)
    BEGIN
        RAISERROR ('Error: Course ID does not exist.', 16, 1);
        RETURN;
    END

    -- Check if Track exists
    IF NOT EXISTS (SELECT 1 FROM Track WHERE T_Id = @T_Id)
    BEGIN
        RAISERROR ('Error: Track ID does not exist.', 16, 1);
        RETURN;
    END

	 INSERT INTO Instructor_Track
    VALUES (@Ins_Id, @T_Id);

	 INSERT INTO Instructor_Course
    VALUES (@Ins_Id, @C_Id);

    
    INSERT INTO Track_Course (T_Id, C_Id)
    VALUES (@T_Id, @C_Id);
END;
GO

 
---------------------------------------------

/*Update*/
/*Not work*/
create proc updatecoursetrack
@id int,
@T_ID int
as
begin
if not exists(
select t.T_Id from Track_Course t
where T_Id=@T_ID
)
begin 
print 'track not exist ..!'
return;
end
    begin
        print 'The combination of Track ID and Course ID already exists.';
        return;
    end
update Track_Course 
set
C_Id=@id
where T_Id=@T_ID
end

 

exec updatecoursetrack 
@T_ID=211,
@id=1014

/*Delete*/
create proc deletecoursetrack
@id int
as
begin
if not exists(
select t.C_Id from Track_Course t
where t.C_Id=@id
)
begin 
print 'course not exist ..!'
return;
end
delete from Track_Course 
where C_Id=@id
end

 

exec deletecoursetrack
@id=1001

exec deletecoursetrack
@id=1001

----------------------------------------------------------

------------- Wesso ------------------------------------
--1) Get Exams
create or alter Proc GetExam @eName varchar(20)
as
	begin
		select * from Exam E
		inner join Exam_Question EQ
		on E.E_Id= EQ.E_Id
		inner join Question Q
		on EQ.Q_Id=Q.Q_Id
		where E.E_Name=@eName
		order by newid()
	end

exec GetExam 'SW'
--------------------------

CREATE OR ALTER PROCEDURE GetExamWithQuestionsForSpecificInstructor
    @E_id INT
AS
BEGIN
    SELECT *
    FROM Exam E
    INNER JOIN Exam_Question EQ ON E.E_Id = EQ.E_Id
    INNER JOIN Question Q ON EQ.Q_Id = Q.Q_Id
    WHERE  E.E_Id = @E_id  
    ORDER BY NEWID(); 
END;
GO

GetExamWithQuestionsForSpecificInstructor
    @E_id = 12 -- 211
 
----------------------------

--2) Get Question By Q_ID
create or alter Proc GetQuestion @q_ID int
as
	begin
		select * from Question Q
		inner join Question_Choices QC
		on Q.Q_Id=QC.Q_Id
		where Q.Q_Id=@q_ID
	end
exec GetExam 'SW'
Exec GetQuestion 56

--3) Insert Question
create or alter Proc Insert_Question @Grade int,@Qtype int, @Question varchar(255) ,@ModelAnswer int
as
	begin
	declare @tye varchar(20);
		if(@Qtype=1)
			set @tye='T/F'
		else
			set @tye='Choices'

		insert into Question 
		values(@Grade,@tye,@Question,@ModelAnswer);
	end

--4) Add Question To Exam
create or alter Proc add_Question_ToExam @ExamID int
as
	begin
		declare @qID int;
		select @qID=Max(Q_Id) from Question
		insert into Exam_Question values(@ExamID,@qID);
	end

Create trigger T_Exam_Question
on Exam_Question
after insert
as
	if exists(select * from inserted)
		select * from inserted
go

--5) Add Qestion and Insert into Exam
create or alter Proc AddAndInsertQuestion @Grade int,@Qtype int, @Question varchar(255) ,@ModelAnswer int,@ExamID int
as
begin
	exec Insert_Question @Grade, @Qtype,@Question,@ModelAnswer
	exec add_Question_ToExam @ExamID
	exec CalTotalGrade @ExamID
end
go


select * from Question
delete from Question where Q_Grade=8

exec Insert_Question 8, 2,'A table can have more',100
exec add_Question_ToExam 1

Exec AddAndInsertQuestion 8, 2,'A table can have more',100,1
 
--6) Add Choices
select Max(Choice_Num) from Question_Choices where Q_Id=93;

create or alter Proc AddChoice @Qid int , @Q_choice varchar(50)
as
	begin
		declare @cNumber int;
		select @cNumber=Max(Choice_Num) from Question_Choices where Q_Id=@Qid;
		if(@cNumber is NULL)
			set @cNumber=0;
		set @cNumber+=1;
		insert into Question_Choices values(@Qid,@cNumber,@Q_choice);
	end

exec AddChoice 93,'Wesso1'

--7) Delete Choice
create or alter Proc DeleteChoice @Qid int,@cNumber int
as
	begin
		delete from Question_Choices
		where Q_Id=@Qid and Choice_Num=@cNumber
	end

Exec DeleteChoice 69,5

--8) Delete Question
create or alter Proc DeleteQuestion @Qid int,@ExamID int
as
	begin
		delete from Question_Choices where Q_Id=@Qid	

		delete from Exam_Question where Q_Id=@Qid

		delete from Question where Q_Id=@Qid

		exec CalTotalGrade @ExamID
	end

exec DeleteQuestion 19 ,1

--9)
create or alter Proc GetAllExams
as
	begin
		select E_Id,E_Name from Exam
	end

Exec GetAllExams;

--------------------------
CREATE OR ALTER PROC GetAllExamsForSpecificStudentBasedOnTrackID
    @St_Id INT
AS
BEGIN


   DECLARE @TrackId INT;
	SELECT @TrackId = Track_Id 
	FROM Student 
	WHERE St_Id =  @St_Id;

	 SELECT E.*
        FROM Exam E
        JOIN Exam_Track ET ON ET.E_Id = E.E_Id  
        JOIN Student S ON S.St_Id = @St_Id
        WHERE S.Track_Id = @TrackId;
     
 
END;
GO



Exec GetAllExamsForSpecificStudentBasedOnTrackID  @St_Id = 120;

------------------------------
CREATE OR ALTER PROCEDURE GetExamsForSpecificInstructor
    @ins_id INT
AS
BEGIN
    SELECT E.E_Id, E.E_Name,E_Duration,E_Total_Score,E_Date
    FROM Exam E
    INNER JOIN Instructor_EExam IE ON E.E_Id = IE.E_Id  
    WHERE IE.Ins_Id = @ins_id;  
END;
GO

Exec GetExamsForSpecificInstructor   @ins_id = 1;

 

------------------


--9)Calculate Total Grade

create or alter Proc CalTotalGrade @exID varchar(20)
as
	begin
		update Exam
		set E_Total_Score=(select SUM(Q_Grade) from Exam E
		inner join Exam_Question EQ
		on E.E_Id=EQ.E_Id
		inner join Question Q
		on EQ.Q_Id=Q.Q_Id
		where E.E_Id=@exID)
		where E_Id=@exID
	end

select * from Exam

--10) get Total grade to specific Exam
create or alter Proc getExamGrade @eName varchar(20)
as
	begin 
		select E_Total_Score from Exam 
		where E_Name=@eName;
	end

exec getExamGrade 'DataBase'

-----------------------------------------
create or alter Proc Insert_Question @Grade int,@Qtype int, @Question varchar(255) ,@ModelAnswer int
as
	begin
	declare @tye varchar(20);
		if(@Qtype=1)
			set @tye='T/F'
		else
			set @tye='Choices'

		insert into Question 
		values(@Grade,@tye,@Question,@ModelAnswer);
	end

--11) Add Question With Choices Exam

 
CREATE OR ALTER PROC AddQuestionWithChoices 
    @Grade INT, 
    @Qtype INT, 
    @Question VARCHAR(255), 
    @ModelAnswer INT, 
    @ExamID INT, 
    @Choices NVARCHAR(MAX)  
AS
BEGIN
    DECLARE @QID INT;

    -- Insert Question
    EXEC Insert_Question @Grade, @Qtype, @Question, @ModelAnswer;

    -- Retrieve the last inserted Question ID
    SELECT @QID = MAX(Q_Id) FROM Question;

    -- Insert the Question into the Exam
    EXEC add_Question_ToExam @ExamID;

    -- Insert Choices if it's a multiple-choice question
    IF @Qtype = 2  
    BEGIN
        DECLARE @Choice NVARCHAR(50);
        DECLARE @ChoiceNum INT = 1;
        DECLARE @Pos INT = 0;
        DECLARE @NextPos INT;

        WHILE LEN(@Choices) > 0
        BEGIN
            SET @NextPos = CHARINDEX(',', @Choices);
            IF @NextPos = 0
            BEGIN
                SET @Choice = @Choices;
                SET @Choices = '';
            END
            ELSE
            BEGIN
                SET @Choice = LEFT(@Choices, @NextPos - 1);
                SET @Choices = RIGHT(@Choices, LEN(@Choices) - @NextPos);
            END

            -- Insert choice
            INSERT INTO Question_Choices (Q_Id, Choice_Num, answer) 
            VALUES (@QID, @ChoiceNum, @Choice);

            SET @ChoiceNum = @ChoiceNum + 1;
        END
    END
	ELSE IF  @Qtype = 1
	 BEGIN
	  INSERT INTO Question_Choices (Q_Id, Choice_Num, answer) 
            VALUES 
                (@QID, 1, 'True'),
                (@QID, 2, 'False');
	 END

    -- Recalculate total exam grade
    EXEC CalTotalGrade @ExamID;
END


--12)Add Student Answer
Create or Alter Proc InsertAnswer @s_ID int,@E_Name varchar(50),@Q_ID int,@S_Ans int,@C_ID int,@E_ID int
as
	begin
		insert into StudenAnswer
		values(@s_ID,@E_Name,@Q_ID,@S_Ans,@C_ID,@E_ID);

	 
	end
--------------------------------------
CREATE OR ALTER PROCEDURE InsertStudentExam 
    @s_ID INT,
    @E_ID INT,
	@Grade float
AS
BEGIN
    INSERT INTO Student_Exam (St_Id, E_Id, Grade)
    VALUES (@s_ID, @E_ID, @Grade);
END;
GO



----------------------------

-- Report that returns the students information according to Track .
create proc GetAllStudentsReportWithTrackId @T_id int 
as 
    select * 
    from Student
    where Track_Id =@T_id

---------------------------------------------
-- Report that returns the students information according to Course .
CREATE OR ALTER PROCEDURE GetAllStudentsReportWithCourseId 
    @C_id INT,
    @Ins_id INT  
AS
BEGIN
    SELECT 
        S.St_Id,
        S.F_Name,
        S.L_Name,
        S.St_Email,
		SP.St_Phone,
        C.C_Name,
        C.C_Duration	
    FROM Student S
    JOIN Course_Student CS ON CS.St_Id = S.St_Id
    JOIN Course C ON CS.C_Id = C.C_Id
    JOIN Instructor_Course IC ON IC.C_Id = C.C_Id 
	Join Student_Phone SP ON SP.St_Id = S.St_Id
    WHERE C.C_Id = @C_id AND IC.Ins_Id = @Ins_id; 
END;
GO


EXEC GetAllStudentsReportWithCourseId @C_id = 2, @Ins_id = 2;


	

--------------------------------------
CREATE OR ALTER PROCEDURE sp_AuthenticateUser
    @Email NVARCHAR(150),
    @Password NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    -- Check Students
    IF EXISTS (SELECT 1 FROM Student WHERE St_Email = @Email AND Password = @Password)
    BEGIN
        SELECT 'Student' AS Role, St_Id AS UserId, F_Name, L_Name, St_Email 
        FROM Student WHERE St_Email = @Email;
        RETURN;
    END

    -- Check Instructors
    IF EXISTS (SELECT 1 FROM Instructor WHERE Ins_Email = @Email AND Password = @Password)
    BEGIN
        SELECT 'Instructor' AS Role, Ins_Id AS UserId, F_Name, L_Name, Ins_Email 
        FROM Instructor WHERE Ins_Email = @Email;
        RETURN;
    END

    -- Check Admins
    IF EXISTS (SELECT 1 FROM Admin WHERE A_Email = @Email AND Password = @Password)
    BEGIN
        SELECT 'Admin' AS Role, A_Id AS UserId, F_Name, L_Name, A_Email 
        FROM Admin WHERE A_Email = @Email;
        RETURN;
    END

    -- Invalid login
    SELECT NULL AS Role, NULL AS UserId, NULL AS F_Name, NULL AS L_Name, NULL AS Email;
END;

-------------------------------------

CREATE OR ALTER PROCEDURE GetAllExamsAndCoursesAndStudents
    @ins_id INT
AS
BEGIN
    SELECT 
        (SELECT COUNT(E_Id) FROM Exam) AS [Total Exams], 
        (SELECT COUNT(St_Id) FROM Student) AS [Total Students], 
        (SELECT COUNT(C_Id) FROM Course) AS [Total Courses]
END;
GO


Exec GetAllExamsAndCoursesAndStudents @ins_id  = 1;


----------------------------------------------------------

CREATE OR ALTER PROCEDURE GetAllExamsAndCoursesAndStudentsForSpecificInstructor
    @ins_id INT
AS
BEGIN
    SELECT 
        -- ✅ Count Exams related to the Instructor
        (
            SELECT COUNT(E.E_Id) 
            FROM Exam E
            JOIN Instructor_EExam IE ON E.E_Id = IE.E_Id
            WHERE IE.Ins_Id = @ins_id
        ) AS [Total Exams], 
        
        -- ✅ Count Students related to the Instructor's Courses
        (
            SELECT COUNT(DISTINCT S.St_Id)
            FROM Student S
            JOIN Course_Student CS ON S.St_Id = CS.St_Id
            JOIN Instructor_Course IC ON CS.C_Id = IC.C_Id
            WHERE IC.Ins_Id = @ins_id
        ) AS [Total Students], 
        
        -- ✅ Count Courses assigned to the Instructor
        (
            SELECT COUNT(DISTINCT C.C_Id) 
            FROM Course C
            JOIN Instructor_Course IC ON C.C_Id = IC.C_Id
            WHERE IC.Ins_Id = @ins_id
        ) AS [Total Courses],

        -- ✅ Count Questions in Exams assigned to the Instructor
        (
            SELECT COUNT(DISTINCT Q.Q_Id) 
            FROM Question Q
            JOIN Exam_Question EQ ON Q.Q_Id = EQ.Q_Id
            JOIN Instructor_EExam IE ON EQ.E_Id = IE.E_Id
            WHERE IE.Ins_Id = @ins_id
        ) AS [Total Questions];
END;
GO



exec GetAllExamsAndCoursesAndStudentsForSpecificInstructor    @ins_id = 1
-------------------------------------------------------------------------------





--- Delete All Tables Data


-- Disable foreign key constraints
EXEC sp_MSforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT ALL"

-- Delete data from all tables
DELETE FROM Admin;
DELETE FROM Branch;
DELETE FROM Branch_Instructor;
DELETE FROM Branch_Track;
DELETE FROM Course;
DELETE FROM Course_Exam;
DELETE FROM Course_Student;
DELETE FROM Exam;
DELETE FROM Exam_Question;
DELETE FROM Exam_Track;
DELETE FROM Instructor;
DELETE FROM Instructor_Course;
DELETE FROM Instructor_EExam;
DELETE FROM Instructor_Phone;
DELETE FROM Instructor_Track;
DELETE FROM Question;
DELETE FROM Question_Choices;
DELETE FROM StudenAnswer;
DELETE FROM Student;
DELETE FROM Student_Exam;
DELETE FROM Student_Phone;
DELETE FROM Track;
DELETE FROM Track_Course;

-- Enable foreign key constraints
EXEC sp_MSforeachtable "ALTER TABLE ? CHECK CONSTRAINT ALL"
