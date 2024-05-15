//aka.ms/new-console-template for more information


using Depedenci;
ISendEmail send = new SendYahoo();

UserManager user = new UserManager(send);

Console.WriteLine(user.UpdateAccount());
