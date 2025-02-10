/*Get Grade
Report Name : GetGrade
*/
create proc GetGrade 
@StudentID int
as
begin
SELECT Student.St_Id, CONCAT(Student.F_Name,' ', Student.L_Name)as FullName,  STRING_AGG(CONCAT(Exam.E_Name, ': ', Student_Exam.Grade), CHAR(10)) AS ExamResults,
SUM(Student_Exam.Grade) AS TotalGrade
FROM     Exam INNER JOIN
                  Student_Exam ON Exam.E_Id = Student_Exam.E_Id INNER JOIN
                  Student ON Student_Exam.St_Id = Student.St_Id
				  where Student.St_Id=@StudentID
				  group by 
				  Student.St_Id, 
                  Student.F_Name, 
				  Student.L_Name
				   
end

drop proc GetGrade

/*Get Student Report
Report Name : GetStudent
*/
create proc GetStudent
@StudentID int
as
begin
SELECT Student.St_Id, Student.F_Name, Student.L_Name, Student.St_Email, Student.Track_Id, Student.St_DOB, Track.T_Name
FROM     Student INNER JOIN
                  Track ON Student.Track_Id = Track.T_Id
				  where Student.St_Id=@StudentID
end

drop proc GetStudent

/*Get number of student in course
Report Name : CourseDetails
*/
create proc GetNumberOfStusent
@InstructorID int
as
begin
    select 
        Instructor_Course.Ins_Id as InstructorID,
        Course.C_Name as CourseName,
        count(Course_Student.St_Id) as NumberOfStudents
    from 
        Course_Student
    inner join
        Instructor_Course on Course_Student.C_Id = Instructor_Course.C_Id
    inner join 
        Course on Course_Student.C_Id = Course.C_Id
    where 
        Instructor_Course.Ins_Id = @InstructorID 
    group by 
        Instructor_Course.Ins_Id, 
        Course.C_Name
end
drop proc GetNumberOfStusent

/*Get Exam
Report Name : GetExam
*/
create proc GetExam
@ExamID int
as
begin
SELECT Exam.E_Name , Question.Q_Title, Question.Q_Id,  STRING_AGG(CONCAT(Question_Choices.Choice_Num, ': ', Question_Choices.answer), CHAR(10)) AS Choicess
FROM     Exam INNER JOIN
                  Exam_Question ON Exam.E_Id = Exam_Question.E_Id INNER JOIN
                  Question ON Exam_Question.Q_Id = Question.Q_Id INNER JOIN
                  Question_Choices ON Question.Q_Id = Question_Choices.Q_Id
				  where Exam.E_Id=@ExamID
				  group by Exam.E_Name, Question.Q_Title, Question.Q_Id;
				  

end

drop proc GetExam

/*Model Answer
Report Name : ModelExam
*/
CREATE PROCEDURE ModelAnswer 
@ExamID int,
@StudentID int
AS
BEGIN
select sa.Exam_ID,sa.S_Id,q.Q_Title,MAX(qa.answer) AS StudentAnswer, 
		MAX(qc.answer) AS ModelAnswer
 from Question q inner join Question_Choices qa on q.Q_Id=qa.Q_Id
 inner join StudenAnswer sa on sa.QID=qa.Q_id and sa.S_Anwer=qa.Choice_Num
 inner join Question_Choices qc on sa.QID=qc.Q_Id and sa.C_Answer=qc.Choice_Num
 where sa.Exam_ID=@ExamID and sa.S_Id=@StudentID 
    GROUP BY sa.Exam_ID, q.Q_Title, sa.S_Id;
END;


drop proc ModelAnswer