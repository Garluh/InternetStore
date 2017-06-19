# InternetStore

Domain\Concrete\EmailOrderProcessor.cs <br>
public string MailToAddress = "order@example.com";          //куда отправлять<br>
public string MailFromAdress = "dressstore@example.com";    //от кого отправлять<br>
public bool UseSsl = true;                                  //Использовать Ssl<br>
public string Username = "MySmtpUsername";                  //Имя пользователя почтового ящика<br>
public string Password = "MySmtpPassword";                  //Пароль от почтового ящика<br>
public string ServerName = "smtp.example.com";              //Адрес или имя сервера<br>
public int ServerPort = 587;                                //Порт  почтового сервера для Ssl<br>
public bool WriteAsFile = true;                             //Записывать почтовое сообщение как файл<br>
public string FileLocation = @"c:\book_store_emails";       //Место хранения почтовых сообщений(каталог должен существовать и иметь разрешение на запись)<br>
<br>
<br>
WebUI\Web.config<br>
<!-- начало Проверка на стороне клинета --><br>
<add key="ClientValidationEnabled" value="true" /><br>
<add key="UnobtrusiveJavaScriptEnabled" value="true" /><br>
<!-- конец Проверка на стороне клинета --><br>
