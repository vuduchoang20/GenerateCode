using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenCodeWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbEntityBase.Items.Add("SimpleEntity");
            cbEntityBase.Items.Add("SimpleFullAuditedEntity");
     
            cbEntityDtoBase.Items.Add("SimpleEntityDto");
            cbEntityDtoBase.Items.Add("SimpleFullAuditedEntityDto");

            cbCreateOrEditEntityDtoBase.Items.Add("SimpleCreateOrEditDto");
            cbCreateOrEditEntityDtoBase.Items.Add("SimpleCreateOrEditEntityDto");
            cbCreateOrEditEntityDtoBase.Items.Add("SimpleFullAuditedCreateOrEditEntityDto");   
        }

        public class GenInput
        {
            public string AppAreaName { get; set; }
            public string EntityName { get; set; }
            public string TableName { get; set; }

            public string PathApp { get; set; }
            public string PathAppShare { get; set; }
            public string PathCore { get; set; }
            public string PathMvc { get; set; }

            public string BaseClassEntity { get; set; }
            public string BaseClassEntityDto { get; set; }
            public string BaseClassCreateOrEditEntityDto { get; set; }

            public string PropertiesEntity { get; set; }
        }

        private async void Generate_Click(object sender, EventArgs e)
        {
            var genInput = new GenInput()
            {
                EntityName = txtEntityName.Text,
                TableName = txtTableName.Text,
                AppAreaName = txtAppArea.Text,

                PathApp = txtPathApplication.Text,
                PathAppShare = txtPathApplicationShared.Text,
                PathCore = txtPathCore.Text,
                PathMvc = txtPathMvc.Text,

                BaseClassEntity = cbEntityBase.Text,
                BaseClassEntityDto = cbEntityDtoBase.Text,
                BaseClassCreateOrEditEntityDto = cbCreateOrEditEntityDtoBase.Text,
            };


            if (dtColumns.Rows.Count > 0)
            {
                var str = "";
                foreach (DataRow dr in dtColumns.Rows)
                {
                    var required = dr["Required"].ToString();
                    if (required == "True")
                    {
                        str += "[Required]\n";
                    }

                    str += "\t \tpublic " + dr["Type"] + " " + dr["Name"] + " { get; set;}\n\n";
                }
                genInput.PropertiesEntity = str;
            }

            //// Mvc
            //await CreateController(genInput);

            //await CreateViewModel(genInput);
            //await CreateOrEditViewModel(genInput);

            //await CreateViewIndex(genInput);
            //await CreateViewCreateOrEditModal(genInput);

            //await CreateIndexJs(genInput);
            //await CreateCreateOrEditJs(genInput);

            //// Application 
            //await CreateImportFromExcelJob(genInput);
            //await CreateAppService(genInput);

            //// Application Core
            //await CreateEntity(genInput);

            //// Application Share
            // await CreateEntityDto(genInput);
            // await CreateOrEditDto(genInput);

            //await CreateGetAllInput(genInput);
            //await CreateGetForEditOutput(genInput);
            //await CreateGetForViewDto(genInput);

            //await CreateImportDto(genInput);
            //await CreateImportFromExcelJobArgs(genInput);

            //await CreateInterfaceAppService(genInput);

            // richTextBox1.Text = "";
            // richTextBox2.Text = "";
        }


       
        public string ReplaceFileText(string fileTemplate, GenInput input)
        {
            var str = File.ReadAllText(fileTemplate);

            str = str.Replace("{{Table_Name}}", input.TableName);
            str = str.Replace("{{Entity_Name}}", input.EntityName);
            str = str.Replace("{{entity_Name}}", char.ToLower(input.EntityName[0]) + input.EntityName.Substring(1));
            str = str.Replace("{{App_Area_Name}}", input.AppAreaName);

            str = str.Replace("{{Path_App}}", input.PathApp.Split(@"\").Last());
            str = str.Replace("{{Path_Core}}", input.PathCore.Split(@"\").Last());
            str = str.Replace("{{Path_App_Shared}}", input.PathAppShare.Split(@"\").Last());

            str = str.Replace("{{Base_Class_Entity_Name}}", input.BaseClassEntity);
            str = str.Replace("{{Base_Class_Entity_Dto_Name}}", input.BaseClassEntityDto);
            str = str.Replace("{{Base_Class_CreateOrEdit_Entity_Dto_Name}}", input.BaseClassCreateOrEditEntityDto);
            str = str.Replace("{{Properties_Entity}}", input.PropertiesEntity);
      
            return str;
        }

        public async Task CreateEntity(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Server/Entity/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Server/Entity/MainTemplate.custom.txt");

            // ghi text vào file mẫu được customize 
            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            // tạo file .cs và ghi nội dung 
            var fileName = Path.Combine(input.PathCore + "/Basic", input.EntityName + ".cs");

            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateInterfaceAppService(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Server/InterfaceAppService/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Server/InterfaceAppService/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            var fileName = Path.Combine(input.PathAppShare + "/Interface/Basic", "I" + input.EntityName + "AppService.cs");
            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateAppService(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Server/AppService/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Server/AppService/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            var fileName = Path.Combine(input.PathApp + "/Services/Basic", input.EntityName + "AppService.cs");
            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateEntityDto(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Server/Dtos/EntityDto/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Server/Dtos/EntityDto/MainTemplate.custom.txt");

            string folderName = Path.Combine(input.PathAppShare + "/Dto/Basic", input.EntityName);
            Directory.CreateDirectory(folderName);

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            var fileName = Path.Combine(folderName, input.EntityName + "Dto" + ".cs");
            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateController(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Client/Controller/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Client/Controller/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            var fileName = Path.Combine(input.PathMvc + "/Areas/Lib/Controllers", input.EntityName + "Controller.cs");

            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateImportFromExcelJob(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Client/ImportFromExcelJob/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Client/ImportFromExcelJob/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            string folderName = Path.Combine(input.PathApp + "/Importing/Category", input.EntityName);
            Directory.CreateDirectory(folderName);

            var fileName = Path.Combine(folderName, "Import" + input.EntityName + "FromExcelJob.cs");

            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateImportFromExcelJobArgs(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Client/ImportFromExcelJobArgs/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Client/ImportFromExcelJobArgs/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            string folderName = Path.Combine(input.PathAppShare + "/Importing/Category", input.EntityName);
            Directory.CreateDirectory(folderName);

            var fileName = Path.Combine(folderName, "Import" + input.EntityName + "FromExcelJobArgs.cs");

            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateImportDto(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Client/ImportDto/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Client/ImportDto/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            string folderName = Path.Combine(input.PathAppShare + "/Importing/Category", input.EntityName);
            Directory.CreateDirectory(folderName);

            var fileName = Path.Combine(folderName, "Import" + input.EntityName + "Dto.cs");

            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateViewIndex(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Client/IndexHtmlTemplate/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Client/IndexHtmlTemplate/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            var folderName = Path.Combine(input.PathMvc + "/Areas/Lib/Views", input.EntityName);
            Directory.CreateDirectory(folderName);

            var fileName = Path.Combine(folderName, "Index.cshtml");
            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateViewCreateOrEditModal(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Client/CreateOrEditHtmlTemplate/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Client/CreateOrEditHtmlTemplate/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            var folderName = Path.Combine(input.PathMvc + "/Areas/Lib/Views", input.EntityName);
            Directory.CreateDirectory(folderName);

            var fileName = Path.Combine(folderName, "_CreateOrEditModal.cshtml");
            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateIndexJs(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Client/IndexJsTemplate/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Client/IndexJsTemplate/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            var folderName = Path.Combine(input.PathMvc + "/wwwroot/view-resources/Areas/Lib", input.EntityName);
            Directory.CreateDirectory(folderName);

            var fileName = Path.Combine(folderName, "Index.js");
            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateCreateOrEditJs(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Client/CreateOrEditJs/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Client/CreateOrEditJs/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            var folderName = Path.Combine(input.PathMvc + "/wwwroot/view-resources/Areas/Lib", input.EntityName);
            Directory.CreateDirectory(folderName);

            var fileName = Path.Combine(folderName, "_CreateOrEditModal.js");
            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateViewModel(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Client/ViewModel/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Client/ViewModel/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            var folderName = Path.Combine(input.PathMvc + "/Areas/Lib/Models", input.EntityName);
            Directory.CreateDirectory(folderName);

            var fileName = Path.Combine(folderName, input.EntityName + "ViewModel.cs");
            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateOrEditViewModel(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Client/CreateOrEditViewModel/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Client/CreateOrEditViewModel/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            var folderName = Path.Combine(input.PathMvc + "/Areas/Lib/Models", input.EntityName);
            Directory.CreateDirectory(folderName);

            var fileName = Path.Combine(folderName, "CreateOrEdit" + input.EntityName + "ViewModel.cs");
            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateOrEditDto(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Server/Dtos/CreateOrEditDto/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Server/Dtos/CreateOrEditDto/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            string folderName = Path.Combine(input.PathAppShare + "/Dto/Basic", input.EntityName);
            Directory.CreateDirectory(folderName);

            var fileName = Path.Combine(folderName, "CreateOrEdit" + input.EntityName + "Dto.cs");
            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateGetAllInput(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Server/Dtos/GetAllInput/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Server/Dtos/GetAllInput/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            string folderName = Path.Combine(input.PathAppShare + "/Dto/Basic", input.EntityName);
            Directory.CreateDirectory(folderName);


            var fileName = Path.Combine(folderName, "GetAll" + input.EntityName + "Input.cs");
            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateGetForEditOutput(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Server/Dtos/GetForEditOutput/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Server/Dtos/GetForEditOutput/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            string folderName = Path.Combine(input.PathAppShare + "/Dto/Basic", input.EntityName);
            Directory.CreateDirectory(folderName);

            var fileName = Path.Combine(folderName, "Get" + input.EntityName + "ForEditOutput.cs");
            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        public async Task CreateGetForViewDto(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Server/Dtos/GetForViewDto/MainTemplate.txt");
            string fileTempCustom = Path.Combine(Application.StartupPath, "FileTemplate/Server/Dtos/GetForViewDto/MainTemplate.custom.txt");

            File.WriteAllText(fileTempCustom, ReplaceFileText(fileTemp, input));

            string folderName = Path.Combine(input.PathAppShare + "/Dto/Basic", input.EntityName);
            Directory.CreateDirectory(folderName);

            var fileName = Path.Combine(folderName, "Get" + input.EntityName + "ForViewDto.cs");
            await File.WriteAllTextAsync(fileName, File.ReadAllText(fileTempCustom));
        }

        private void AssignPath(string pathType)
        {
            var folderDlg = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true
            };

            DialogResult result = folderDlg.ShowDialog();

            if(result == DialogResult.OK)
            {
                switch (pathType)
                {
                    case "Core":
                        txtPathCore.Text = folderDlg.SelectedPath;
                        break;
                    case "App":
                        txtPathApplication.Text = folderDlg.SelectedPath;
                        break;
                    case "AppShared":
                        txtPathApplicationShared.Text = folderDlg.SelectedPath;
                        break;
                    case "Mvc":
                        txtPathMvc.Text = folderDlg.SelectedPath;
                        break;
                }
            }
        }

        private void btnSelectPathApp_Click(object sender, EventArgs e)
        {
            AssignPath("App");
        }

        private void btnSelectPathCore_Click(object sender, EventArgs e)
        {
            AssignPath("Core");
        }

        private void btnSelectPathAppShared_Click(object sender, EventArgs e)
        {
            AssignPath("AppShared");
        }

        private void btnSelectPathMvc_Click(object sender, EventArgs e)
        {
            AssignPath("Mvc");
        }


        private DataTable dtColumns = new DataTable(); 

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            AddNewField();
        }

        private void NewRow(string type, string name, bool required)
        {
            var newRow = dtColumns.NewRow();

            newRow["Type"] = type;
            newRow["Name"] = name;
            newRow["Required"] = required;

            dtColumns.Rows.Add(newRow);
        }
        private void AddNewField()
        {
            NewRow("", "", false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadDataTable();
        }

        private void ReloadDataTable()
        {
            if (dtColumns == null || dtColumns.Columns.Count == 0)
            {
                dtColumns = new DataTable();
                dtColumns.Columns.Add("Type", typeof(string));
                dtColumns.Columns.Add("Name", typeof(string));
                dtColumns.Columns.Add("Required", typeof(bool));
            }
            gridControl1.DataSource = dtColumns;
        }

        private void ReplacePermisson(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Permisson/TemplatePermisson.txt");

            var strReplace = ReplaceFile(fileTemp, input);

            richTextBox1.Text = strReplace;
        }

        private void ReplaceAddPermisson(GenInput input)
        {
            string fileTemp = Path.Combine(Application.StartupPath, "FileTemplate/Permisson/TemplateAddPermisson.txt");

            var strReplace = ReplaceFile(fileTemp, input);

            richTextBox2.Text = strReplace;
        }

        public string ReplaceFile(string fileTemplate, GenInput input)
        {
            var str = File.ReadAllText(fileTemplate);
            str = str.Replace("{{Entity_Name}}", input.EntityName);
            str = str.Replace("{{entity_Name}}", char.ToLower(input.EntityName[0]) + input.EntityName.Substring(1));
            str = str.Replace("{{App_Area_Name}}", input.AppAreaName);
            return str;
        }

        private void txtEntityName_TextChanged(object sender, EventArgs e)
        {
            GenInput input = new GenInput();
            input.EntityName = txtEntityName.Text;
            input.AppAreaName = txtAppArea.Text;

            ReplacePermisson(input);
            ReplaceAddPermisson(input);
        }
    }
}
