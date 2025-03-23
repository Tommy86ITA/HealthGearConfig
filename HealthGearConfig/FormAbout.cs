using System.Reflection;

namespace HealthGearConfig
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            VersionLoader();
            LicenseLoader();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Chiude il form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Carica il file di licenza RTF.
        /// </summary>
        private void LicenseLoader()
        {
            var assembly = Assembly.GetExecutingAssembly();
            using Stream stream = assembly.GetManifestResourceStream("HealthGearConfig.Assets.License.rtf");
            if (stream != null)
            {
                richTextBoxLicense.LoadFile(stream, RichTextBoxStreamType.RichText);
            }
            else
            {
                richTextBoxLicense.Text = "Impossibile caricare la licenza.";
            }
        }

        private void VersionLoader()
        {
            // --- VERSIONE (GitInformationalVersion) ---
            var buildDate = System.IO.File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location);
            string version = Assembly.GetExecutingAssembly()
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                .InformationalVersion ?? "N/A";
            labelSwVersion.Text = $"Versione: {version} - Build date: {buildDate:dd/MM/yyyy}";
        }
    }
}
