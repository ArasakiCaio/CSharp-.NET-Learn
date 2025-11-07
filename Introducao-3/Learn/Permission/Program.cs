
using System.Diagnostics;

void permissionVerify(string permission, int level)
{
    if (permission.Contains("Admin"))
    {
        Console.WriteLine("Welcome, " + (level > 55 ? "Super " : "") + "Admin user.");
    }
    else if (permission.Contains("Manager") && level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}

// Se o usuário for um administrador com um nível maior que 55
string permission = "Admin|Manager";
int level = 56;
// Welcome, Super Admin user.
permissionVerify(permission, level);

// Se o usuário for um administrador com um nível menor ou igual a 55
permission = "Admin|Manager";
level = 55;
// Welcome, Admin user.
permissionVerify(permission, level);

// Se o usuário for um gerente com um nível maior ou igual a 20
permission = "Manager";
level = 20;
// Contact an Admin for access.
permissionVerify(permission, level);

// Se o usuário for um gerente com um nível menor que 20
permission = "Manager";
level = 19;
// You do not have sufficient privileges.
permissionVerify(permission, level);

// Se o usuário não for um Administrador ou um Gerente
permission = "User";
level = 100;
// You do not have sufficient privileges.
permissionVerify(permission, level);