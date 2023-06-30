//Elabore una aplicación con una clase empleado (Nombre, apellido, cargo, CUIL, cantidad de hijos a cargo y años de antigüedad).
//Un método LiquidarSueldo que mostrará en pantalla la liquidación, que contendrá: el nombre completo, el CUIL y el sueldo a percibir.
//Se sabe que en la empresa hay cinco cargos que perciben un sueldo básico diferente: Asistente ($ 100000), Operador ($ 150000), Ejecutivo de cuenta ($200000), Gerente ($500000) y Director ejecutivo($900000)
//Se sabe asimismo que los empleados tienen derecho a percibir un importe de $10000 como asignación familiar por hijo a cargo y el 7% más de su sueldo básico por año de antigüedad.
//Ingrese varios empleados y calcule su sueldo.

var empleado1 = new Empleado();
empleado1.Nombre="Jona";
empleado1.Apellido="Silva";
empleado1.Cargo=Empleado.TipoCargo.Director;
empleado1.CUIL="222222222";
empleado1.Antiguedad=1;
empleado1.CantHijos=0;
empleado1.LiquidarSueldo();
public class Empleado{
    public Empleado(){

    }
    public Empleado(string nombre, string apellido){
        this.Nombre=nombre;
        this.Apellido=apellido;
    }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public TipoCargo Cargo { get; set; }
    public string CUIL { get; set; }
    public int CantHijos { get; set; }
    public int Antiguedad { get; set; }
    public enum TipoCargo{
        Asistente,
        Operador,
        Ejecutivo,
        Gerente,
        Director,
    }
    
    public void LiquidarSueldo(){
            double sueldoBasico =0;
            switch (this.Cargo){
                case TipoCargo.Asistente:
                sueldoBasico=100000;
                break;
            case TipoCargo.Operador:
                sueldoBasico=150000;
                break;
            case TipoCargo.Ejecutivo:
                sueldoBasico=200000;
                break;
            case TipoCargo.Gerente:
                sueldoBasico=500000;
                break;
            case TipoCargo.Director:
                sueldoBasico=900000;
                break;
        }
        sueldoBasico+= 10000*this.CantHijos;
        sueldoBasico+= Antiguedad*sueldoBasico*0.07 ;
        Console.WriteLine($"{this.Nombre} {this.Apellido} Cuil: {this.CUIL} Sueldo: {sueldoBasico} ");
    }
}
