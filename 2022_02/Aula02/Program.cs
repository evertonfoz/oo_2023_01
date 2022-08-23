using Aula01.Domain;

Student student = new();
Console.WriteLine(student.StudentID);
Console.WriteLine(student.UuidID);

//try
//{
//	student.StudentID = 1;
//    Console.WriteLine("Registro realizado com sucesso");
//}
//catch (ArgumentException)
//{
//    Console.WriteLine("Erro ao registrar ID");
//}


//var result = student.RegisterStudentID(1);
//if (!result)
//{
//    Console.WriteLine("Erro ao registrar ID");
//} else
//{
//    Console.WriteLine("Registro realizado com sucesso");
//}

Student academic = new();
academic.Name = "1234";