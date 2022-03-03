
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Utilities.Classes
{
    public class SQLite
    {
        private SqliteConnection connection = new SqliteConnection("Data Source=UtilitiesTID.db");
        private SqliteCommand command = new SqliteCommand();
        private SqliteDataReader reader;
        private CustomMessage customMessage = new CustomMessage();

        public SQLite() {
        }

        #region Code
        public Code InsertCode(Code code, Form parent) {

            if (code == null) { return code; }

            connection.Open();
            command.Connection = connection;
            try {
                command.CommandText = "INSERT INTO Codes(Name,Code,Type) VALUES ('" + code.Name + "','" + code.CodeText + "','" + code.Type + "')";
                command.ExecuteScalar(); // using ExecuteNonQuery can't return last_insert_rowid()
                command.CommandText = "SELECT Id,Name,Code,Type FROM Codes WHERE rowid = last_insert_rowid();";
                reader = command.ExecuteReader();
                while (reader.Read()) {
                    code = new Code(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                }
                reader.Close();
                customMessage = new CustomMessage("Code sucessfuly registred.", "Success", "success");
            } catch (Exception ex) {
                customMessage = new CustomMessage("Error registering:\n" + ex.Message, "Error", "error");
            }
            CustomDialog.ShowCustomDialog(customMessage, parent);
            connection.Close();
            return code;
        }
        public CustomMessage UpdateCode(Code code) {

            if (code == null) { return customMessage; }
            connection.Open();
            command.Connection = connection;
            try {
                command.CommandText = "UPDATE Codes SET Name = '" + code.Name + "',Code = '" + code.CodeText + "', Type = '" + code.Type + "'" +
                                      " WHERE ID  = " + code.ID;
                command.ExecuteNonQuery();
                customMessage = new CustomMessage("Code sucessfuly updated.", "Sucess", "sucess");
            } catch (Exception ex) {
                customMessage = new CustomMessage("Error updating:\n" + ex.Message, "Error", "error");
            }
            connection.Close();
            return customMessage;
        }
        public CustomMessage DeleteCode(Code code) {

            if (code == null) { return customMessage; }
            connection.Open();
            command.Connection = connection;
            try {
                command.CommandText = "DELETE FROM Codes WHERE Name = '" + code.Name + "' AND Type = '" + code.Type + "'";
                Clipboard.SetText(command.CommandText);
                command.ExecuteNonQuery();
                customMessage = new CustomMessage("Code sucessfuly deleted.", "Sucess", "success");
            } catch (Exception ex) {
                customMessage = new CustomMessage("Error deleting:\n" + ex.Message, "Error", "error");
            }
            connection.Close();
            return customMessage;
        }
        public CustomMessage DeleteAllCodes() {
            connection.Open();

            command.Connection = connection;
            try {
                command.CommandText = "DELETE FROM Codes";
                Clipboard.SetText(command.CommandText);
                command.ExecuteNonQuery();
                customMessage = new CustomMessage("Codes sucessfuly deleted.", "Sucess", "success");
            } catch (Exception ex) {
                customMessage = new CustomMessage("Error deleting:\n" + ex.Message, "Error", "error");
            }
            connection.Close();
            return customMessage;
        }

        public DataTable SelectAllCodes(string filterType) {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Type");
            dt.Columns.Add("Code");

            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT Id,Name,Type,Code FROM Codes";

            if (!filterType.Equals("")) {
                command.CommandText = command.CommandText + " WHERE Type = '" + filterType + "'";
            }

            try {
                reader = command.ExecuteReader();
                while (reader.Read()) {
                    Code code = new Code(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    code.DeformatStrings();

                    dt.Rows.Add(code.ID, code.Name, code.Type, code.CodeText);
                }
                reader.Close();
            } catch (Exception ex) {
                CustomMessage customMessage = new CustomMessage(ex.Message, "Error", "error");
                CustomDialog.ShowCustomDialog(customMessage, null);
            }
            connection.Close();

            return dt;
        }
        public DataTable SelectAllCodeTypes() {

            DataTable dt = new DataTable();
            dt.Columns.Add("Type");

            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT DISTINCT Type FROM Codes";
            try {
                reader = command.ExecuteReader();
                while (reader.Read()) {
                    dt.Rows.Add(reader.GetString(0));
                }
                reader.Close();
            } catch (Exception ex) {
                CustomMessage customMessage = new CustomMessage(ex.Message, "Error", "error");
                CustomDialog.ShowCustomDialog(customMessage, null);
            }
            connection.Close();

            return dt;
        }
        #endregion

        #region FileFilters
        public FileFilter InsertFileFilter(FileFilter fileFilter, Form parent) {

            if (fileFilter == null) { return fileFilter; }

            connection.Open();
            command.Connection = connection;
            try {
                command.CommandText = "INSERT INTO FileFilters(Name,Notes) VALUES ('" + fileFilter.Name + "','" + fileFilter.Notes + "');";
                command.ExecuteScalar(); // using ExecuteNonQuery can't return last_insert_rowid()
                command.CommandText = "SELECT Id,Name,Notes FROM FileFilters WHERE rowid = last_insert_rowid();";
                reader = command.ExecuteReader();
                while (reader.Read()) {
                    fileFilter = new FileFilter(Convert.ToInt32(reader.GetString(0)), reader.GetString(1), reader.GetString(2));
                }
                reader.Close();
                customMessage = new CustomMessage("File Filter sucessfuly registred.", "Success", "success");
            } catch (Exception ex) {
                customMessage = new CustomMessage("Error registering:\n" + ex.Message, "Error", "error");
            }
            CustomDialog.ShowCustomDialog(customMessage, parent);
            connection.Close();
            return fileFilter;
        }
        public CustomMessage UpdateFileFilter(FileFilter fileFilter) {

            if (fileFilter == null) { return customMessage; }
            connection.Open();
            command.Connection = connection;
            try {
                command.CommandText = "UPDATE FileFilter SET Name = '" + fileFilter.Name + "'" +
                                      " WHERE ID  = " + fileFilter.ID;
                command.ExecuteNonQuery();
                customMessage = new CustomMessage("File Filter sucessfuly updated.", "Sucess", "sucess");
            } catch (Exception ex) {
                customMessage = new CustomMessage("Error updating:\n" + ex.Message, "Error", "error");
            }
            connection.Close();
            return customMessage;
        }
        public CustomMessage DeleteFileFilter(FileFilter fileFilter) {

            if (fileFilter == null) { return customMessage; }
            connection.Open();
            command.Connection = connection;
            try {
                command.CommandText = "DELETE FROM FileFilterConditions WHERE id_FileFilter = " + fileFilter.ID;
                command.ExecuteNonQuery();
                command.CommandText = "DELETE FROM FileFilters WHERE id = " + fileFilter.ID;
                command.ExecuteNonQuery();
                customMessage = new CustomMessage("File Filter sucessfuly deleted.", "Sucess", "success");
            } catch (Exception ex) {
                customMessage = new CustomMessage("Error deleting:\n" + ex.Message, "Error", "error");
            }
            connection.Close();
            return customMessage;
        }

        public FileFilterCondition InsertFileFilterCondition(FileFilterCondition fileFilterCondition, Form parent) {
            if (fileFilterCondition == null) { return fileFilterCondition; }

            connection.Open();
            command.Connection = connection;
            try {
                command.CommandText = String.Format("INSERT INTO FileFilterConditions(id_FileFilter,Type,Condition) " +
                                      "VALUES ({0},'{1}','{2}')", fileFilterCondition.IdFileFilter, fileFilterCondition.Type, fileFilterCondition.Condition);
                command.ExecuteNonQuery();
                command.CommandText = "SELECT Id,id_FileFilter,Type,Condition FROM FileFilterConditions WHERE rowid = = last_insert_rowid();";
                reader = command.ExecuteReader();
                while (reader.Read()) {
                    fileFilterCondition = new FileFilterCondition(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3));
                }
                reader.Close();
                customMessage = new CustomMessage("File Filter Condition sucessfuly registred.", "Success", "success");
            } catch (Exception ex) {
                customMessage = new CustomMessage("Error registering:\n" + ex.Message, "Error", "error");
            }
            CustomDialog.ShowCustomDialog(customMessage, parent);
            connection.Close();
            return fileFilterCondition;
        }
        public CustomMessage UpdateFileFilterCondition(FileFilterCondition fileFilterCondition) {

            if (fileFilterCondition == null) { return customMessage; }
            connection.Open();
            command.Connection = connection;
            try {
                command.CommandText = String.Format("UPDATE FileFilterConditions SET Condition = '{0}', Type = '{1}' " +
                                      "WHERE ID  = {2}", fileFilterCondition.Condition, fileFilterCondition.Type, fileFilterCondition.ID);
                command.ExecuteNonQuery();
                customMessage = new CustomMessage("File Filter Condition sucessfuly updated.", "Sucess", "sucess");
            } catch (Exception ex) {
                customMessage = new CustomMessage("Error updating:\n" + ex.Message, "Error", "error");
            }
            connection.Close();
            return customMessage;
        }
        public CustomMessage DeleteFileFilterCondition(FileFilterCondition fileFilterCondition) {

            if (fileFilterCondition == null) { return customMessage; }
            connection.Open();
            command.Connection = connection;
            try {
                command.CommandText = "DELETE FROM FileFilterConditions WHERE id = " + fileFilterCondition.ID;
                command.ExecuteNonQuery();
                customMessage = new CustomMessage("File Filter Condition sucessfuly deleted.", "Sucess", "success");
            } catch (Exception ex) {
                customMessage = new CustomMessage("Error deleting:\n" + ex.Message, "Error", "error");
            }
            connection.Close();
            return customMessage;
        }


        public DataTable SelectAllFileFilters() {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Notes");

            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT Id,Name,Notes FROM FileFilters";

            try {
                reader = command.ExecuteReader();
                while (reader.Read()) {
                    FileFilter fileFilter = new FileFilter(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    dt.Rows.Add(fileFilter.ID, fileFilter.Name, fileFilter.Notes);
                }
                reader.Close();
            } catch (Exception ex) {
                CustomMessage customMessage = new CustomMessage(ex.Message, "Error", "error");
                CustomDialog.ShowCustomDialog(customMessage, null);
            }
            connection.Close();

            return dt;
        }
        public DataTable SelectAllFileFilterConditions(int idFileFilter, string conditionType) {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Condition");
            dt.Columns.Add("Type");

            connection.Open();
            command.Connection = connection;

            try {
                command.CommandText = String.Format("SELECT Id,Condition,Type FROM FileFilterConditions WHERE id_FileFilter = {0}", idFileFilter);
                if (conditionType != null && !conditionType.Equals("")) {
                    command.CommandText += String.Format(" AND Type = '{0}'", conditionType);
                }
                reader = command.ExecuteReader();
                while (reader.Read()) {
                    dt.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                }
                reader.Close();
            } catch (Exception ex) {
                CustomMessage customMessage = new CustomMessage(ex.Message, "Error", "error");
                CustomDialog.ShowCustomDialog(customMessage, null);
            }
            connection.Close();

            return dt;
        }

        public List<FileFilterCondition> SelectFileFilterConditions(int idFileFilter, string conditionType) {

            FileFilterCondition fileFilterCondition;
            List<FileFilterCondition> list = new List<FileFilterCondition>();

            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT Id,Type,Condition FROM FileFilterConditions WHERE Id_FileFilter = " + idFileFilter;
            if (conditionType != null && !conditionType.Equals("")) {
                command.CommandText += String.Format(" AND Type = '{0}'", conditionType);
            }
            try {
                reader = command.ExecuteReader();
                while (reader.Read()) {
                    fileFilterCondition = new FileFilterCondition(reader.GetInt32(0), idFileFilter, reader.GetString(1), reader.GetString(2));
                    fileFilterCondition.SetConditionLowerCase();
                    list.Add(fileFilterCondition);
                }
                reader.Close();
            } catch (Exception ex) {
                CustomMessage customMessage = new CustomMessage(ex.Message, "Error", "error");
                CustomDialog.ShowCustomDialog(customMessage, null);
            }
            connection.Close();

            return list;
        }
        #endregion

        public CustomMessage CreateDatabase() {

            connection.Open();
            command.Connection = connection;
            command.CommandText = "CREATE TABLE IF NOT EXISTS Codes (" +
                                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                                    "Name Varchar(50) NOT NULL," +
                                    "Code Varchar(2000) NOT NULL," +
                                    "Type Varchar(30) NOT NULL," +
                                    "UNIQUE (Name,Type)" +
                                  ");" +
                                  "CREATE TABLE IF NOT EXISTS FileFilters (" +
                                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                                    "Name Varchar(50) NOT NULL," +
                                    "Notes Varchar(2000) NULL," +
                                    "UNIQUE (Name)" +
                                  ");" +
                                  "CREATE TABLE IF NOT EXISTS FileFilterConditions (" +
                                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                                    "id_FileFilter INTEGER NOT NULL," +
                                    "Type Varchar(30) NOT NULL," +
                                    "Condition Varchar(1000) NOT NULL," +
                                    "UNIQUE (id_FileFilter,Type,Condition)," +
                                    "FOREIGN KEY(id_FileFilter) REFERENCES FileFilters(id)" +
                                  ");";

            try {
                command.ExecuteNonQuery();
            } catch (Exception ex) {
                customMessage = new CustomMessage(ex.Message, "Error", "error");
            }
            connection.Close();
            return customMessage;
        }
        public CustomMessage AddDefaultCodes() {

            connection.Open();
            command.Connection = connection;
            List<Code> listCodes = LoadDefaultOptionsCode();
            String[,] arrayClarionNotes = LoadArrayDefaultOptionsClarionNotes();
            try {
                for (int i = 0; i < listCodes.Count; i++) {
                    listCodes[i].FormatStrings();
                    command.CommandText = "INSERT OR IGNORE INTO Codes(Name,Code,Type) VALUES ('" + listCodes[i].Name + "','" + listCodes[i].CodeText + "','" + listCodes[i].Type + "')";
                    command.ExecuteNonQuery();
                }

            } catch (Exception ex) {
                customMessage = new CustomMessage(ex.Message, "Error", "error");
            }
            connection.Close();
            return customMessage;
        }
        private List<Code> LoadDefaultOptionsCode() {
            List<Code> listCodes = new List<Code>();
            listCodes.Add(new Code("Acronym (Default Test)"));
            listCodes.Add(new Code("APP (Allow only one Instance)"));
            listCodes.Add(new Code("Browse (Page Refresh)"));
            listCodes.Add(new Code("Browse (Refresh)"));
            listCodes.Add(new Code("Cla Table (Key)"));
            listCodes.Add(new Code("Column (Width Change)"));
            listCodes.Add(new Code("Column Group (Width Change)"));
            listCodes.Add(new Code("Directory (Create)"));
            listCodes.Add(new Code("Message (Error)"));
            listCodes.Add(new Code("Message (Warning)"));
            listCodes.Add(new Code("Message Case (Yes / No)"));
            listCodes.Add(new Code("Message TID (Error)"));
            listCodes.Add(new Code("Message TID (Warning)"));
            listCodes.Add(new Code("Owner Database (Get)"));
            listCodes.Add(new Code("Print (Multiline String Manually)"));
            listCodes.Add(new Code("Process Label (Change Text Down)"));
            listCodes.Add(new Code("Process Label (Change Text Up)"));
            listCodes.Add(new Code("Queue (Add Record)"));
            listCodes.Add(new Code("Queue (Read All Records)"));
            listCodes.Add(new Code("Record (Delete Child Record)"));
            listCodes.Add(new Code("TabelaSQL (Select)"));
            listCodes.Add(new Code("TabelaSQL (Update)"));
            listCodes.Add(new Code("Window (Force Refresh)"));
            listCodes.Add(new Code("Process Label (Change Text Down)"));
            listCodes.Add(new Code("List Owner (.ap~)"));

            String text = "";
            for (int i = 0; i < listCodes.Count; i++) {
                text = "";
                //switch clarion codes
                switch (listCodes[i].Name) {
                    case "Print (Multiline String Manually)":
                        text = "SETTARGET(REPORT)" +
                               "\r\n?LOC:Observacao {PROP:Text} = LOC:Observacao" +
                               "\r\nnTotLinha# = ?LOC:Observacao {PROP:LineCount}" +
                               "\r\nLOOP J# = 1 TO nTotLinha#" +
                               "\r\n   LOC:ObservacaoLinha = ?LOC:Observacao {PROP:Line,J#}" +
                               "\r\n   PRINT(RPT:Detail)" +
                               "\r\nEND" +
                               "\r\nSETTARGET";
                        break;
                    case "TabelaSQL (Select)":
                        text = "TabelaSQL{Prop:SQLRowSet} = 'SELECT FROM WHERE'" +
                               "\r\nIF ERRORCODE()" +
                               "\r\n  SourceMensagemTID('Erro na instrução SQL !!!||'& FILEERRORCODE() &': '&FILEERROR(),|" +
                               "\r\n                    'ERRO: '& ERRORCODE(),'Icon:Hand','1','1',1,'Mensagem','PEDVENDA',1,2)" +
                               "\r\nEND" +
                               "\r\nLOOP" +
                               "\r\n   NEXT(TabelaSQL)" +
                               "\r\n   IF ERRORCODE() THEN BREAK END" +
                               "\r\n   " +
                               "\r\nEND";
                        break;
                    case "TabelaSQL (Update)":
                        text = "TabelaSQL{Prop:SQLRowSet} = 'UPDATE SET WHERE'" +
                                "\r\nIF ERRORCODE()" +
                                "\r\n   SourceMensagemTID('Erro na instrução SQL !!!||'& FILEERRORCODE() &': '&FILEERROR(),|" +
                                "\r\n                     'ERRO: '& ERRORCODE(),'Icon:Hand','1','1',1,'Mensagem','PEDVENDA',1,2)" +
                                "\r\nEND";
                        break;
                    case "Message TID (Warning)":
                        text = "SourceMensagemTID('Mensagem de exemplo','Atenção',|" +
                                "\r\n             'Icon:Exclamation','1','1',1,'Mensagem','PEDVENDA',1,02)";
                        break;
                    case "Message TID (Error)":
                        text = "SourceMensagemTID('Mensagem de exemplo','Atenção',|" +
                               "\r\n              'Icon:Hand','1','1',1,'Mensagem','PEDVENDA',1,02)";
                        break;
                    case "Message Case (Yes / No)":
                        text = "Case Message('Confirma gravação?','Mensagem',|" +
                               "\r\n         Icon:Question,'&Sim|&Não',1,0)" +
                               "\r\nOF 1" +
                               "\r\nOF 2" +
                               "\r\n    DO ProcedureReturn" +
                               "\r\nEND";
                        break;
                    case "Message (Warning)":
                        text = "Message('Mensagem de exemplo','Atenção',|" +
                               "\r\n    ICON:Exclamation,BUTTON:OK,BUTTON:OK,1)";
                        break;
                    case "Message (Error)":
                        text = "Message('Mensagem de exemplo','Erro: ',|" +
                               "\r\n    ICON:Hand,BUTTON:OK,BUTTON:OK,1)";
                        break;
                    case "Window (Force Refresh)":
                        text = "ForceRefresh = True" +
                               "\r\nLocalRequest = OriginalRequest" +
                               "\r\nDO RefreshWindow";
                        break;
                    case "Process Label (Change Text Up)":
                        text = "(?Progress:UserString) {PROP:TEXT} = 'Carregando Ped.Nr.: '& FORMAT(LOC:NrPedido,@n7.`0)" +
                               "\r\nDISPLAY";
                        break;
                    case "Process Label (Change Text Down)":
                        text = "(?Progress:PctText) {PROP:TEXT} = 'Ped.Nr.: '& FORMAT(LOC:NrPedido,@n7.`0)" +
                               "\r\nDISPLAY";
                        break;
                    case "Owner Database (Get)":
                        text = "PosicaoInicial# = INSTRING(',',GLO:Owner,1,1)" +
                               "\r\nPosicaoFinal# = INSTRING(',',GLO:Owner,1,PosicaoInicial# + 1)" +
                               "\r\nLOC:DataBase = SUB(GLO:Owner,PosicaoInicial# + 1,PosicaoFinal# - PosicaoInicial# - 1) &'.DBO.'";
                        break;
                    case "Queue (Add Record)":
                        text = "QUE:Descricao = 'Erro ao limpar o faturamento'" +
                               "\r\nGET(QUE:MarcaFaturadoErros,+QUE:Descricao)" +
                               "\r\nIF ERRORCODE()" +
                               "\r\n   QUE:Descricao = 'Erro ao limpar o faturamento'" +
                               "\r\n   QUE:Sequencias = ISPDATA:Sequencia" +
                               "\r\n   ADD(QUE:MarcaFaturadoErros,+QUE:Descricao)" +
                               "\r\nELSE" +
                               "\r\n   QUE:Sequencias = CLI(QUE:Sequencias)&', '&ISPDATA:Sequencia" +
                               "\r\n   PUT(QUE:MarcaFaturadoErros)" +
                               "\r\nEND";
                        break;
                    case "Column (Width Change)":
                        text = "?Browse:1{PropList:Width,13} = 0";
                        break;
                    case "Column Group (Width Change)":
                        text = "?Browse:1{PropList:Width + PropList:Group,3} = 0";
                        break;
                    case "Directory (Create)":
                        text = "! COPY FILE CLIB.CLW TO APP FOLDER THEN ADD TO PROJECT" +
                               "\r\n! ADD TO GLOBAL EMBEDS > INSIDE GLOBAL MAP:" +
                               "\r\n! INCLUDE('CLIB.CLW')" +
                               "\r\nIF NOT EXISTS('\\TIDSCI\\EXETPS\\EMP' & FORMAT(GLO: Empresa, @n02) & '\\NFE\\EXPORT')" +
                               "\r\n   LOC:Diretorio = '\\TIDSCI\\EXETPS\\EMP' & FORMAT(GLO: Empresa, @n02) & '\\NFE\\EXPORT'" +
                               "\r\n   MKDIR(LOC:Diretorio)" +
                               "\r\nEND";
                        break;
                    case "APP (Allow only one Instance)":
                        text = "! COPY FILE CWUTIL.INC TO APP FOLDER THEN ADD TO PROJECT" +
                                "\r\n! ADD TO GLOBAL EMBEDS > INSIDE GLOBAL MAP:" +
                                "\r\n! INCLUDE('CWUTIL.INC'),ONCE" +
                                "\r\nIF NOT BeginUnique('HISTFCLI.EXE')" +
                                "\r\n   YIELD()" +
                                "\r\n   CASE MESSAGE('O Histórico Financeiro já está aberto ...','Atenção',|" +
                                "\r\n                ICON:Asterisk,BUTTON:OK,BUTTON:OK,0)" +
                                "\r\n   OF BUTTON:OK" +
                                "\r\n      HALT()" +
                                "\r\n   END" +
                                "\r\nEND";
                        break;
                    case "Acronym (Default Test)":
                        text = "CON1:Matricula = GLO:Matricula" +
                                "\r\nCON11:CodigoSistema = 'TEI'" +
                                "\r\nGET(ContrAcesso,CON1:OrdemMatriculaSistema)" +
                                "\r\nIF ERRORCODE()" +
                                "\r\n   MESSAGE('ATENÇÃO: Acesso Não Permitido!',| " +
                                "\r\n          'Sigla de Acesso: '& CON1:CodigoSistema,'\\TIDSCI\\FIGURAS\\SEMACESS.ICO',|" +
                                "\r\n           Button:OK,Button:OK,1)" +
                                "\r\n   DO ProcedureReturn" +
                                "\r\nEND" +
                                "\r\nSourceGravaDetalheSistema('BCR',393,'Baixa Carga Entregue',|" +
                                "\r\n                          'Exp.>Contr.Entregas>Mov.>Romaneio Entregas>','EXPEDICA.APP')";
                        break;
                    case "Record (Delete Child Record)":
                        text = "!End of Procedure Before closing Files" +
                                "\r\nIF (LocalRequest = DeleteRecord AND LocalResponse = RequestCompleted) OR |" +
                                "\r\n   (LocalRequest = InsertRecord AND LocalResponse = RequestCancelled)" +
                                "\r\n" +
                                "\r\n   TabelaProdSQL{Prop:SQL} = 'DELETE FROM LoteFichaProducaoGenericaItens'&|" +
                                "\r\n                            ' WHERE SequenciaLote = ' & LFPG:SequenciaLote" +
                                "\r\n   IF ERRORCODE()" +
                                "\r\n      SourceMensagemTID('Erro na instrução SQL !!!||' & FILEERRORCODE() & ': ' & FILEERROR(),|" +
                                "\r\n                        'ERRO: '& ERRORCODE(),'Icon:Hand','1','1', 1,'Mensagem','PRODGEN',1,135)" +
                                "\r\n   END" +
                                "\r\nEND";
                        break;
                    case "Browse (Refresh)":
                        text = "DO BRW1::SelectSort";
                        break;
                    case "Queue (Read All Records)":
                        text = "LOOP I# = 1 TO RECORDS(QUE:PedidosGerados)" +
                               "\r\n   GET(QUE:PedidosGerados,I#)" +
                               "\r\n   IF ERRORCODE() THEN BREAK END" +
                               "\r\n   " +
                               "\r\nEND";
                        break;
                    case "Cla Table (Key)":
                        text = "LOC:Chave = FORMAT(GLO:Matricula, @n03) & ' ' & FORMAT(TODAY(), @D06b) &|" +
                               "\r\n' ' & FORMAT(CLOCK(), @T04b) & '_'" +
                               "\r\nRandoms# = 30 - LEN(CLIP(LOC:Chave))" +
                               "\r\nLOOP I# = 1 TO Randoms#" +
                               "\r\n   CASE(RANDOM(1,3))" +
                               "\r\n      OF 1" +
                               "\r\n         LOC:Chave = CLIP(LOC:Chave) & RANDOM(0, 9)" +
                               "\r\n      OF 2" +
                               "\r\n         LOC:Chave = CLIP(LOC:Chave) & CHR(RANDOM(97, 122))" +
                               "\r\n      OF 3" +
                               "\r\n         LOC:Chave = CLIP(LOC:Chave) & CHR(RANDOM(65, 90))" +
                               "\r\n   END" +
                               "\r\nEND";
                        break;
                    case "Browse (Page Refresh)":
                        text = "DO BRW1::RefreshPage";
                        break;
                }


                if (!text.Equals("")) {
                    text = text.Replace("'", "''");
                    listCodes[i].Type = "Clarion";
                    listCodes[i].CodeText = text;
                    continue;
                }

                switch (listCodes[i].Name) {
                    case "List Owner (.ap~)":
                        text = "dir S:\\TIDSCI\\APLICS\\*.ap~ /s /Q";
                        break;
                }
                if (!text.Equals("")) {
                    text = text.Replace("'", "''");
                    listCodes[i].Type = "Command Line";
                    listCodes[i].CodeText = text;
                    continue;
                }
            }
            return listCodes;
        }
        private String[,] LoadArrayDefaultOptionsClarionNotes() {
            String[,] array = new string[,] { { "Fix Clarion Browser ScrollBar (Numeric Key)", "" } };
            String text = "";
            for (int i = 0; i < array.GetLength(0); i++) {
                switch (array[i, 0]) {
                    case "Fix Clarion Browser ScrollBar (Numeric Key)":
                        text = "On Browse > Actions > Scroll Behavior" +
                               "\r\n Set ScrollBar Type = Movable Thumb" +
                               "\r\n Set Key Distribution = Runtime" +
                               "\r\nThen on Runtime Distribution Parameters" +
                               "\r\n Check the option Use Numeric Characters";
                        break;
                }
                text = text.Replace("'", "''");
                array.SetValue(text, i, 1);
            }
            return array;
        }
    }
}
