namespace GeneradorAleatorio
{
    public partial class Form1 : Form
    {
        int seleccion;
        int cantidad;
        double semilla = 0;
        int k = 0;
        double m = 0;
        double x0 = 0;
        double x1 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cantidad = int.Parse(txtCant.Value.ToString());
            k = txtX0.Value.ToString().Length; //Calculamos k

            if (seleccion == 0)
            {
                x0 = double.Parse(txtX0.Text);
                MetodoCuadradosCentrales();
            }
            else
            {
                x0 = double.Parse(txtX0.Text);
                x1 = double.Parse(txtX1.Text);

                MetodoProductosCentrales();
            }
        }

        
        private void MetodoCuadradosCentrales()
        {
            List<Data> list = new();
            m = Math.Pow(10, k); //se calcula M

            try
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (x0 >= 0 && x0 < m)
                    {
                        Data data = new();
                        //elevamos la semilla al cuadrado
                        double value = Math.Pow(x0, 2);

                        var stringTemp = value.ToString();
                        data.Xn2 = stringTemp;

                        //calculamos la posicicion inicial desde donde tomaremos los numeros centrales
                        int posInicial = (stringTemp.Length - k) / 2;

                        //extraemos los numeros centrales
                        stringTemp = stringTemp.Substring(posInicial, k);

                        x0 = double.Parse(stringTemp);

                        data.Id = i + 1;
                        data.Numero = double.Parse(stringTemp) / m;
                        data.XnCentrales = x0.ToString();

                        list.Add(data);
                    }
                }
            }
            catch
            {
                MessageBox.Show("No es posible generar esa cantidad de numeros");
            }

            dataGridView1.DataSource = list;
        }

        private void MetodoProductosCentrales()
        {
            List<Data2> list = new();
            m = Math.Pow(10, k);

            try
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (x0 >= 0 && x0 < m)
                    {
                        Data2 data = new();
                        //multiplicamos las semillas
                        semilla = x0 * x1;
                        var stringTemp = semilla.ToString();
                        data.Xn2 = stringTemp;

                        //calculamos la posicicion inicial desde donde tomaremos los numeros centrales
                        int posInicial = (stringTemp.Length - k) / 2;

                        //extraemos los numeros centrales
                        stringTemp = stringTemp.Substring(posInicial, k);

                        data.Id = i + 1;
                        data.Numero = double.Parse(stringTemp) / m;
                        data.XnCentrales = stringTemp;
                        data.X0 = x0.ToString();
                        data.X1 = x1.ToString();

                        list.Add(data);
                        x0 = x1;
                        x1 = double.Parse(stringTemp);
                    }
                }
            }
            catch
            {
                MessageBox.Show("No es posible generar esa cantidad de numeros");
            }

            dataGridView1.DataSource = list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> opciones = new();
            opciones.Add("Cuadrados Centrales");
            opciones.Add("Productos Centrales");

            comboBox1.DataSource = opciones;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion = comboBox1.SelectedIndex;

            if(seleccion == 0)
            {
                lblx1.Visible = false;
                txtX1.Visible = false;
            }
            else
            {
                lblx1.Visible = true;
                txtX1.Visible = true;
            }
        }
    }
}