namespace BubbleSort
{
    public partial class Form1 : Form
    {
        
        private List<Estudiante> estudiantes;

        public Form1()
        {
            InitializeComponent();
            estudiantes = new List<Estudiante>();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            estudiantes.Add(new Estudiante("Ana Pérez", "12345", 85));
            estudiantes.Add(new Estudiante("Juan García", "67890", 92));
            estudiantes.Add(new Estudiante("María López", "54321", 78));

            dataGridView1.DataSource = estudiantes;
        }

        
        private void btnOrdenarPorNombre_Click(object sender, EventArgs e)
        {
            BubbleSortNombre(estudiantes);  
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = estudiantes;
        }

        private void btnOrdenarPorCalificacion_Click(object sender, EventArgs e)
        {
            BubbleSortCalificacion(estudiantes);  
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = estudiantes;
        }

        
        private void BubbleSortNombre(List<Estudiante> estudiantes)
        {
            for (int i = 0; i < estudiantes.Count - 1; i++)
            {
                for (int j = 0; j < estudiantes.Count - i - 1; j++)
                {
                    if (string.Compare(estudiantes[j].Nombre, estudiantes[j + 1].Nombre) > 0)
                    {
                        
                        var temp = estudiantes[j];
                        estudiantes[j] = estudiantes[j + 1];
                        estudiantes[j + 1] = temp;
                    }
                }
            }
        }

        
        private void BubbleSortCalificacion(List<Estudiante> estudiantes)
        {
            for (int i = 0; i < estudiantes.Count - 1; i++)
            {
                for (int j = 0; j < estudiantes.Count - i - 1; j++)
                {
                    if (estudiantes[j].Calificacion < estudiantes[j + 1].Calificacion)
                    {
                        
                        var temp = estudiantes[j];
                        estudiantes[j] = estudiantes[j + 1];
                        estudiantes[j + 1] = temp;
                    }
                }
            }
        }
    
