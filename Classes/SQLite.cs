
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Utilities.Classes
{
    public class SQLite
    {
        private SqliteConnection connection = new SqliteConnection("Data Source=UtilitiesTID.db");
        private SqliteCommand command = new SqliteCommand();

        public SQLite() {
            CreateDatabase();
            AddCodeToClipboard();
        }

        private void CreateDatabase() {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "CREATE TABLE IF NOT EXISTS CodeToClipboard (" +
                                    "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                                    "Name Varchar(50) NOT NULL," +
                                    "Code Varchar(2000) NOT NULL," +
                                    "UNIQUE (Name)"+
                                  ");";
            try {
                command.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        private void AddCodeToClipboard() {
            connection.Open();
            command.Connection = connection;
            String[,] arrayCodes = LoadArrayCodeToClipboard();
            try {
                for (int i = 0; i < arrayCodes.GetLength(0); i++) {
                    command.CommandText = "INSERT OR IGNORE INTO CodeToClipboard(Name,Code) VALUES ('" + arrayCodes[i, 0] + "','" + arrayCodes[i, 1] + "')";
                    command.ExecuteNonQuery();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        private String[,] LoadArrayCodeToClipboard() {
            String[,] array = new string[,]{ {"Acronym(Default Test)",""},
                                {"APP(Allow only one Instance)",""},
                                {"Browse(Refresh)",""},
                                {"CLA Table(Key)",""},
                                {"Column(Width Change)",""},
                                {"Column Group(Width Change)",""},
                                {"Directory(Create)",""},
                                {"Message(Error)",""},
                                {"Message(Warning",""},
                                {"Message Case(Yes/ No)",""},
                                {"Message TID(Error)",""},
                                {"Message TID(Warning)",""},
                                {"Owner Database(Get)",""},
                                {"Print(Multiline String Manually)",""},
                                {"Process Label(Change Text Down)",""},
                                {"Process Label(Change Text Up)",""},
                                {"Queue(Add Record)",""},
                                {"Queue(Read All Records)",""},
                                {"Record(Delete Child Record)",""},
                                {"TabelaSQL(Select)",""},
                                {"TabelaSQL(Update)",""},
                                {"Window(Force Refresh)",""} };

            for (int i = 0; i < array.GetLength(0); i++) {
                switch (array[i,0]) {
                    case "Print (Multiline String Manually) ":
                        array[i,1] = "SETTARGET(REPORT)" +
                               "\r\n?LOC:Observacao {PROP:Text} = LOC:Observacao" +
                               "\r\nnTotLinha# = ?LOC:Observacao {PROP:LineCount}" +
                               "\r\nLOOP J# = 1 TO nTotLinha#" +
                               "\r\n   LOC:ObservacaoLinha = ?LOC:Observacao {PROP:Line,J#}" +
                               "\r\n   PRINT(RPT:Detail)" +
                               "\r\nEND" +
                               "\r\nSETTARGET";
                        break;
                    case "TabelaSQL (Select)":
                        array[i,1] = "TabelaSQL{Prop:SQLRowSet} = 'SELECT FROM WHERE'" +
                                "\r\nIF ERRORCODE()" +
                                "\r\n   SourceMensagemTID('Erro na instrução SQL !!!||'& FILEERRORCODE() &': '&FILEERROR(),|" +
                                "\r\n                     'ERRO: '& ERRORCODE(),'Icon:Hand','1','1',1,'Mensagem','PEDVENDA',1,2)" +
                                "\r\nEND" +
                                "\r\nLOOP" +
                                "\r\n   NEXT(TabelaSQL)" +
                                "\r\n   IF ERRORCODE() THEN BREAK END" +
                                "\r\n   " +
                                "\r\nEND";
                        break;
                    case "TabelaSQL (Update)":
                        array[i,1] = "TabelaSQL{Prop:SQLRowSet} = 'UPDATE SET WHERE'" +
                                "\r\nIF ERRORCODE()" +
                                "\r\n   SourceMensagemTID('Erro na instrução SQL !!!||'& FILEERRORCODE() &': '&FILEERROR(),|" +
                                "\r\n                     'ERRO: '& ERRORCODE(),'Icon:Hand','1','1',1,'Mensagem','PEDVENDA',1,2)" +
                                "\r\nEND";
                        break;
                    case "Message TID (Warning)":
                        array[i,1] = "SourceMensagemTID('Mensagem de exemplo','Atenção',|" +
                                "\r\n                   'Icon:Exclamation','1','1',1,'Mensagem','PEDVENDA',1,02)";
                        break;
                    case "Message TID (Error)":
                        array[i,1] = "SourceMensagemTID('Mensagem de exemplo','Atenção',|" +
                               "\r\n                   'Icon:Hand','1','1',1,'Mensagem','PEDVENDA',1,02)";
                        break;
                    case "Message Case (Yes/No)":
                        array[i,1] = "Case Message('Confirma gravação?','Mensagem',|" +
                               "\r\n             Icon:Question,'&Sim|&Não',1,0)" +
                               "\r\nOF 1" +
                               "\r\nOF 2" +
                               "\r\n    DO ProcedureReturn" +
                               "\r\nEND";
                        break;
                    case "Message (Warning)":
                        array[i,1] = "Message('Mensagem de exemplo','Atenção',|" +
                               "\r\n             ICON:Exclamation,BUTTON:OK,BUTTON:OK,1)";
                        break;
                    case "Message (Error)":
                        array[i,1] = "Message('Mensagem de exemplo','Erro: ',|" +
                               "\r\n             ICON:Hand,BUTTON:OK,BUTTON:OK,1)";
                        break;
                    case "Window (Force Refresh)":
                        array[i,1] = "ForceRefresh = True" +
                               "\r\nLocalRequest = OriginalRequest" +
                               "\r\nDO RefreshWindow";
                        break;
                    case "Process Label (Change Text Up)":
                        array[i,1] = "(?Progress:UserString) {PROP:TEXT} = 'Carregando Ped.Nr.: '& FORMAT(LOC:NrPedido,@n7.`0)" +
                               "\r\nDISPLAY";
                        break;
                    case "Process Label (Change Text Down)":
                        array[i,1] = "(?Progress:PctText) {PROP:TEXT} = 'Ped.Nr.: '& FORMAT(LOC:NrPedido,@n7.`0)" +
                               "\r\nDISPLAY";
                        break;
                    case "Owner Database (Get)":
                        array[i,1] = "PosicaoInicial# = INSTRING(',',GLO:Owner,1,1)" +
                               "\r\nPosicaoFinal# = INSTRING(',',GLO:Owner,1,PosicaoInicial# + 1)" +
                               "\r\nLOC:DataBase = SUB(GLO:Owner,PosicaoInicial# + 1,PosicaoFinal# - PosicaoInicial# - 1) &'.DBO.'";
                        break;
                    case "Queue (Add Record)":
                        array[i,1] = "QUE:Descricao = 'Erro ao limpar o faturamento'" +
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
                        array[i,1] = "?Browse:1{PropList:Width,13} = 0";
                        break;
                    case "Column Group (Width Change)":
                        array[i,1] = "?Browse:1{PropList:Width + PropList:Group,3} = 0";
                        break;
                    case "Directory (Create)":
                        array[i,1] = "! COPY FILE CLIB.CLW TO APP FOLDER THEN ADD TO PROJECT" +
                               "\r\n! ADD TO GLOBAL EMBEDS > INSIDE GLOBAL MAP:" +
                               "\r\n! INCLUDE('CLIB.CLW')" +
                               "\r\nIF NOT EXISTS('\\TIDSCI\\EXETPS\\EMP' & FORMAT(GLO: Empresa, @n02) & '\\NFE\\EXPORT')" +
                               "\r\n   LOC:Diretorio = '\\TIDSCI\\EXETPS\\EMP' & FORMAT(GLO: Empresa, @n02) & '\\NFE\\EXPORT'" +
                               "\r\n   MKDIR(LOC:Diretorio)" +
                               "\r\nEND";
                        break;
                    case "APP (Allow only one Instance)":
                        array[i,1] = "! COPY FILE CWUTIL.INC TO APP FOLDER THEN ADD TO PROJECT" +
                                "\r\n! ADD TO GLOBAL EMBEDS > INSIDE GLOBAL MAP:" +
                                "\r\n! INCLUDE('CWUTIL.INC'),ONCE" +
                                "\r\nIF NOT BeginUnique('HISTFCLI.EXE')" +
                                "\r\n   YIELD()" +
                                "\r\n   CASE MESSAGE('O Histórico Financeiro já está aberto ...','Atenção',ICON: Asterisk,BUTTON: OK,BUTTON: OK,0)" +
                                "\r\n   OF BUTTON:OK" +
                                "\r\n      HALT()" +
                                "\r\n   END" +
                                "\r\nEND";
                        break;
                    case "Acronym (Default Test)":
                        array[i,1] = "CON1:Matricula = GLO:Matricula" +
                                "\r\nCON11:CodigoSistema = 'TEI'" +
                                "\r\nGET(ContrAcesso,CON1:OrdemMatriculaSistema)" +
                                "\r\nIF ERRORCODE()" +
                                "\r\n   MESSAGE('ATENÇÃO: Acesso Não Permitido!',| " +
                                "\r\n          'Sigla de Acesso: '& CON1:CodigoSistema,'\\TIDSCI\\FIGURAS\\SEMACESS.ICO',Button:OK,Button:OK,1)" +
                                "\r\n   DO ProcedureReturn" +
                                "\r\nEND" +
                                "\r\nSourceGravaDetalheSistema('BCR',393,'Baixa Carga Entregue','Exp.>Contr.Entregas>Mov.>Romaneio Entregas>','EXPEDICA.APP')";
                        break;
                    case "Record (Delete Child Record)":
                        array[i,1] = "!End of Procedure Before closing Files" +
                                "\r\nIF (LocalRequest = DeleteRecord AND LocalResponse = RequestCompleted) OR |" +
                                "\r\n   (LocalRequest = InsertRecord AND LocalResponse = RequestCancelled)" +
                                "\r\n   TabelaProdSQL{Prop:SQL} = 'DELETE FROM LoteFichaProducaoGenericaItens WHERE SequenciaLote = ' & LFPG:SequenciaLote" +
                                "\r\n   IF ERRORCODE()" +
                                "\r\n      SourceMensagemTID('Erro na instrução SQL !!!||' & FILEERRORCODE() & ': ' & FILEERROR(),|" +
                                "\r\n                        'ERRO: '& ERRORCODE(),'Icon:Hand','1','1', 1,'Mensagem','PRODGEN',1,135)" +
                                "\r\n   END" +
                                "\r\nEND";
                        break;
                    case "Browse (Refresh)":
                        array[i,1] = "DO BRW1::SelectSort";
                        break;
                    case "Queue (Read All Records)":
                        array[i,1] = "LOOP I# = 1 TO RECORDS(QUE:PedidosGerados)" +
                               "\r\n   GET(QUE:PedidosGerados,I#)" +
                               "\r\n   IF ERRORCODE() THEN BREAK END" +
                               "\r\n   " +
                               "\r\nEND";
                        break;
                    case "CLA Table (Key)":
                        array[i,1] = "LOC:Chave = FORMAT(GLO: Matricula, @n03) & ' ' & FORMAT(TODAY(), @D06b) & ' ' & FORMAT(CLOCK(), @T04b) & '_'" +
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
                }
            }
            return array;
        }



    }
}
