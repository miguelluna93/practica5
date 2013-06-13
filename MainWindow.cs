using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBotonSumarClicked (object sender, System.EventArgs e)
	{
		//Sumar
		int numero1;
		int numero2;
		int resultado;
		
		
		numero1 =int.Parse(this.entryNumero1.Text);
        numero2 = int.Parse(this.entryNumero2.Text);
		resultado= numero1 + numero2;
		entryResultado.Text = resultado.ToString();
		//throw new System.NotImplementedException ();
	}

	protected void OnBotonRestarClicked (object sender, System.EventArgs e)
	{
		//Restar
		int numero1;
		int numero2;
		int resultado;
		
		
		numero1 =int.Parse(this.entryNumero1.Text);
        numero2 = int.Parse(this.entryNumero2.Text);
		resultado= numero1 - numero2;
		entryResultado.Text = resultado.ToString();
	}

	protected void OnBotonMultiplicarClicked (object sender, System.EventArgs e)
	{
		//Multiplicar
		int numero1;
		int numero2;
		int resultado;
		
		
		numero1 =int.Parse(this.entryNumero1.Text);
        numero2 = int.Parse(this.entryNumero2.Text);
		resultado= numero1 * numero2;
		entryResultado.Text = resultado.ToString();
	}

	protected void OnBotonDividirClicked (object sender, System.EventArgs e)
	{
		//Dividir
		int numero1;
		int numero2;
		int resultado;
		
		
		numero1 =int.Parse(this.entryNumero1.Text);
        numero2 = int.Parse(this.entryNumero2.Text);
		resultado= numero1 / numero2;
		entryResultado.Text = resultado.ToString();
	}
}
