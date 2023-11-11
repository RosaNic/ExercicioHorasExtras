Console.WriteLine
    ("--- Horas Extras ---\n");

Console.WriteLine
    ($"salario-hora {6:C}, {220} horas, sendo {0,2} horas-extra, salário = {Salario(6, 220, 0):C}");

Console.WriteLine
    ($"salario-hora {6:C}, {220} horas, sendo {40} horas-extra, salário = {Salario(6, 220, 20):C}");

Console.WriteLine
    ($"salario-hora {10:C}, {300} horas, sendo {0,2} horas-extra, salário = {Salario(10, 300, 0):C}");

Console.WriteLine
    ($"salario-hora {24:C}, {290} horas, sendo {20} horas-extra, salário = {Salario(24, 290, 20):C}");

double Salario(double salarioHora, double horasTotais, double horasExtras)
{
    return (salarioHora * (horasTotais - horasExtras)) + (salarioHora * horasExtras * 1.4);
}