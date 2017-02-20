using System;

public class Cliente
{


    public String dni {  get; set; }
    public String nombre { get; set; }
    public String telefono { get; set; }
    public String contacto { get; set; }
    public String mail { get; set; }

    public Cliente() { }

    public Cliente(String dni, String nombre, String telefono, String contacto, String mail)
	{
        this.dni=dni;
        this.nombre = nombre;
        this.telefono = telefono;
        this.contacto = contacto;
        this.mail = mail;
	}

}
