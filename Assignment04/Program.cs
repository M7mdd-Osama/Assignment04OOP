using System;
using System.Data;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Channels;
using System.ComponentModel.DataAnnotations;
using Assignment04.Part02_Q03;

namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 Q1 : What is the primary purpose of an interface in C#?
            //b) To define a blueprint for a class
            #endregion

            #region Q2 : Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private
            #endregion

            #region Q3 : Can an interface contain fields in C#?
            //b) No
            #endregion

            #region Q4 : In C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q5 : Which keyword is used to implement an interface in a class in C#?
            //d) implements => :
            #endregion

            #region Q6 : Can an interface contain static methods in C#?
            //a) Yes (C# 8.0)
            #endregion

            #region Q7 : In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public
            #endregion

            #region Q8 : What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access
            #endregion

            #region Q9 : In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors
            #endregion

            #region Q10 : How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas
            #endregion

            #region Part02 Q01 : Define an interface named IShape with a property Area and a method DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from IShape. Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.
            //ICircle circle = new Circle(2);
            //IRectangle rectangle = new Rectangle(3,5);
            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();
            #endregion

            #region Part02 Q02
            ///In this example, we start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser.The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.
            ///In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored credentials.It returns true if the user is authenticated and false otherwise.The AuthorizeUser method checks if the user with the given username has the specified role.It returns true if the user is authorized and false otherwise.
            ///In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type IAuthenticationService.We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.
            ///This implementation allows you to switch the authentication service implementation easily by creating a new class that implements the IAuthenticationService interface and providing the desired logic for authentication and authorization.

            //IAuthenticationService auth = new BasicAuthenticationService();

            //string username = "Ali";
            //string password = "02468";
            //bool isAuthenticated = auth.AuthenticateUser(username, password);
            //Console.WriteLine($"Authentication for {username}: {isAuthenticated}");

            //string role = "admin";
            //bool isAuthorized = auth.AuthorizeUser(username, role);
            //Console.WriteLine($"Authorization for {username} with role {role}: {isAuthorized}");

            //BasicAuthenticationService authService1 = new BasicAuthenticationService();
            //BasicAuthenticationService authService2 = new BasicAuthenticationService();
            //int comparisonResult = authService1.CompareTo(authService2);
            //Console.WriteLine($"Comparison result between two authentication services: {comparisonResult}");
            #endregion

            #region Part02 Q03
            ///we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
            ///We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.
            ///In each implementation, we provide the logic to send notifications through the respective communication channel:
            ///The EmailNotificationService class simulates sending an email by outputting a message to the console.
            ///The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
            ///The PushNotificationService class simulates sending a push notification by outputting a message to the console.
            ///In the Main method, we create instances of each notification service class and call the SendNotification method with sample recipient and message values.
            ///This implementation allows you to easily switch between different notification channels by creating new classes that implement the INotificationService interface and provide the specific logic for each channel.

            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //emailService.SendNotification("mohamed@gmail.com", "Email Message");
            //smsService.SendNotification("Osama@gmail.com", "SMS Message");
            //pushService.SendNotification("Ali@gmail.com", "Push Message");
            #endregion
        }
    }
}
