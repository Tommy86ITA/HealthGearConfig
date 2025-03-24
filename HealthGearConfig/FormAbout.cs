using System.Reflection;
using System.Windows.Forms;

namespace HealthGearConfig
{
    public partial class FormAbout : Form
    {
        private const string License = "HealthGearConfig.Assets.License.rtf";

        public FormAbout()
        {
            InitializeComponent();
            GetVersionInfo();
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
            using Stream? stream = assembly.GetManifestResourceStream(License);
            if (stream != null)
            {
                richTextBoxLicense.LoadFile(stream, RichTextBoxStreamType.RichText);
            }
            else
            {
                richTextBoxLicense.Text = "Impossibile caricare la licenza.";
            }
        }

        /// <summary>
        /// Ottiene le informazioni sulla versione dell'applicazione.
        /// </summary>
        /// <returns></returns>
        private static (string Version, string Commit, string BuildDate) GetVersionInfo()
        {
            var buildDate = File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location);
            string version = Assembly
                .GetExecutingAssembly()
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                .InformationalVersion ?? "N/D";

            string versionShort = version.Split('+')[0]; // es: "1.0.0"
            string commitHash = version.Contains('+') ? version.Split('+')[1] : "N/A";
            string commitShort = commitHash.Length >= 7 ? commitHash.Substring(0, 7) : commitHash;

            return (versionShort, commitShort, buildDate.ToString("dd/MM/yyyy"));
        }

        /// <summary>
        /// Carica le informazioni sulla versione dell'applicazione.
        /// </summary>
        private void VersionLoader()
        {
            var (version, commit, buildDate) = GetVersionInfo();
            labelSwVersion.Text = $"Versione: {version}";
            labelBuild.Text = $"Build: {commit}";
            labelBuildDate.Text = $"Build date: {buildDate}";
        }

        /// <summary>
        /// Copia le informazioni sulla versione negli appunti.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelCopy_Click(object sender, EventArgs e)
        {

            var (version, commit, buildDate) = GetVersionInfo();
            string versionInfo = $"HealthGearConfig\nVersione: {version}\nBuild: {commit}\nBuild date: {buildDate}";
            Clipboard.SetText(versionInfo);
            labelCopy.Text = "Copiato negli appunti!";
            timerCopied.Start();

        }

        /// <summary>
        /// Chiude il form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void timerCopied_Tick(object sender, EventArgs e)
        {
            timerCopied.Stop();
            labelCopy.Text = "Copia informazioni";
        }
    }
}
