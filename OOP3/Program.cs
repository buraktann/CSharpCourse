// See https://aka.ms/new-console-template for more information
using OOP3;

ICreditManager needCreditManager = new NeedCreditManager();
ICreditManager vehicleLoanManager = new VehicleLoanManager();
ICreditManager housingCreditManager = new HousingCreditManager();
ICreditManager tradesmenCreditManager = new TradesmenCreditManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();
ILoggerService smsLoggerService = new SmsLoggerService();

List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new DatabaseLoggerService() };

ApplicationManager appManager = new ApplicationManager();
appManager.Apply(tradesmenCreditManager, loggers);

List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager,vehicleLoanManager};
//appManager.ProvideLoanPreNotification(credits);

