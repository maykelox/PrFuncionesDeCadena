namespace PrFuncionesDeCadena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Declaracion de variable
            
            string cadena = txtCadena.Text;
            //Aplicar funciones
           
            //calculamos la longitud de la cadena

            txtLongitud.Text = Convert.ToString (cadena.Length);
           
            //mostrar primera cadena

            txtPrimerCaracter.Text = cadena.Substring(0, 1);
           
            //Mostrar el ultimo caracter

            txtUltimoCaracter.Text = cadena.Substring(cadena.Length-1, 1);
           
            //Mostrar el segundo caracter
            txt26.Text = cadena.Substring(1, 5);

            //buscamos la ubicacion de la primera letra A

            txtPrimeraLetra.Text = Convert.ToString(cadena.IndexOf("A", 0) + 1);

            //Convertir toda la cadena en mayuscula

            txtMayuscula.Text = cadena.ToUpper();

            //Convertimos toda la cadena en minuscula

            txtMinuscula.Text = cadena.ToLower();

            // borrar los espacio en blanco de la cadena de texto

            txtEspacioEnBlanco.Text = cadena.Replace(" ", "");

        }
    }
}