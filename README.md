# FirstExam
Restaurant Ordering Menu
Changes for it to work:
On MailingService Class, input your  Email in smtpClient.Credential and input your password, then input your email again in smtpClient.Send at From part.
Change DinerMail Class CompanyEmail To your desired email which will be the companies mail.
Order client email is inputed during program.
Files Folder has the Drinks,Meals and Order Archive.
At Repositories folder: DrinksRepository and MealRepository Edit the :
var readLines = read.FileReader(@"C:\Users\Kornelijus\source\repos\ExamFunc\ExamFunc\Files\Meals.CSV.txt"); line with your own path for the respective CSV files.
In Functions folder edit the FileWriter Class and change the string path into your own path to the OrderLog.
