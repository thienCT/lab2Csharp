using System;
using System.ComponentModel;
using System.Security.Cryptography;
class Program{
    static void Main(){
    string userName = "admin";
    string passWord = "123";
    double balance = 5000;

    System.Console.WriteLine("enter userName");
    string inputUserName = Console.ReadLine();
    System.Console.WriteLine("enter password");
    string inputPassword = Console.ReadLine();

    if(inputUserName == userName && inputPassword == passWord){
        System.Console.WriteLine("login success");
    }else{
        System.Console.WriteLine("login fail");
    }

    while(true)
    {
        System.Console.WriteLine("/menu chuc nang");
        System.Console.WriteLine("1. rut tien");
        System.Console.WriteLine("2. nap tien");
        System.Console.WriteLine("3. kiem tra toan khoan ");
        System.Console.WriteLine("4. exit");

        System.Console.WriteLine("enter choice");
        string choice = Console.ReadLine();

        switch(choice){
         case "1":
         try{
            RutTien(ref balance);
         }catch (Exception ex){
            System.Console.WriteLine("fail: " + ex.Message);
         }
         break;
         case "2":
         try{
            NapTien(ref balance);
         }catch (Exception ex){
            System.Console.WriteLine("fail: " + ex.Message);
         }
         break;
         case "3":
            KiemTraTaiKhoan(balance);
            break;
         case "4":
            System.Console.WriteLine("good bye: ");
            return;
         default:
            System.Console.WriteLine("lua chon khong hop le ");
            break;
        }
    }

     else
    {
        System.Console.WriteLine("login fail");

    }
    static void RutTien(ref double balance){
        System.Console.WriteLine("nhap so tien muon rut");
        double amount; 
        if(!double.TryParse(Console.ReadLine(), out amount))
        {
            throw new Exception ("so tien rut khong hop le");

        }
        if (amount % 50 != 0 || amount > balance){
             throw new Exception("so tien rut khong hop le");
        }
        double discount = amount * 0.067;
        balance  -= amount - discount ;
        System.Console.WriteLine("rut tien thanh cong");
        System.Console.WriteLine("so du con lai trong tai khoan: " + balance);
}
    }
   
static void NapTien(ref double balance){
    System.Console.WriteLine("nhap so tien muon nap ");
    double amount;
    if (!double.TryParse(Console.ReadLine(), out amount ) || amount <= 0){
        throw new Exception (" so tien khong hop le");

    }
    double discount = amount * 0;
    balance  += amount- discount;
    System.Console.WriteLine("nap tien thanh cong");
    System.Console.WriteLine("so du hien tai trong tai khoan ");
}
static void KiemTraTaiKhoan (double balance){
    System.Console.WriteLine(" so du hien tai trong tai khoan : " + balance);
}
    }


    
    



