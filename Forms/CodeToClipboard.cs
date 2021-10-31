using System;
using System.Data;
using System.Windows.Forms;
using Utilities.Classes;

namespace Utilities
{
    public partial class CodeToClipboard : Form
    {
        private readonly SQLite sqlite = new SQLite();
        public CodeToClipboard() {
            InitializeComponent();
        }
        private void CodeToClipboard_Load(object sender, EventArgs e) {
            RefreshCodeTypes();
            RefreshCodeNames();
        }
        private void RefreshCodeNames() {
            DataTable dt;
            if (cboCodeType.SelectedItem != null) {
                dt = sqlite.SelectAllCodes(cboCodeType.SelectedValue.ToString());
            } else {
                dt = sqlite.SelectAllCodes("");
            }
            cboCodeName.DataSource = dt;
            cboCodeName.DisplayMember = "Name";
            cboCodeName.ValueMember = "Code";
            cboCodeName.Refresh();
            
        }
        private void RefreshCodeTypes() {
            DataTable dt = sqlite.SelectAllCodeTypes();
            dt.Rows.Add("");
            cboCodeType.DataSource = dt;
            cboCodeType.DisplayMember = "Type";
            cboCodeType.ValueMember = "Type";
            cboCodeType.Refresh();
            cboCodeType.SelectedItem = null;
        }

        private void BtnCopyClipboard_Click(object sender, EventArgs e) {
            if (cboCodeName.SelectedItem != null) {
                Clipboard.SetText(cboCodeName.SelectedValue.ToString());
                txtCodePreview.Text = cboCodeName.Text + "\r\nCopied to clipboard successfully.";
            }
        }

        private void CboCodeName_SelectedValueChanged(object sender, EventArgs e) {
            if (cboCodeName.SelectedItem != null) {
                txtCodePreview.Text = "Preview: \r\n" + cboCodeName.SelectedValue.ToString();
            }
        }

        private void cboCodeType_SelectedValueChanged(object sender, EventArgs e) {
            if (cboCodeType.SelectedItem != null) {
                RefreshCodeNames();
            }
        }


        //private string ClipboardClarionText() {//add print line detail for a multi line text field
        //    string text = "";
        //    switch (cboClarionCode.Text) {
        //        case "Print (Multiline String Manually) ":
        //            text = "SETTARGET(REPORT)" +
        //                   "\r\n?LOC:Observacao {PROP:Text} = LOC:Observacao" +
        //                   "\r\nnTotLinha# = ?LOC:Observacao {PROP:LineCount}" +
        //                   "\r\nLOOP J# = 1 TO nTotLinha#" +
        //                   "\r\n   LOC:ObservacaoLinha = ?LOC:Observacao {PROP:Line,J#}" +
        //                   "\r\n   PRINT(RPT:Detail)" +
        //                   "\r\nEND" +
        //                   "\r\nSETTARGET";
        //            break;
        //        case "TabelaSQL (Select)":
        //            text = "TabelaSQL{Prop:SQLRowSet} = 'SELECT FROM WHERE'" +
        //                    "\r\nIF ERRORCODE()" +
        //                    "\r\n   SourceMensagemTID('Erro na instrução SQL !!!||'& FILEERRORCODE() &': '&FILEERROR(),|" +
        //                    "\r\n                     'ERRO: '& ERRORCODE(),'Icon:Hand','1','1',1,'Mensagem','PEDVENDA',1,2)" +
        //                    "\r\nEND" +
        //                    "\r\nLOOP" +
        //                    "\r\n   NEXT(TabelaSQL)" +
        //                    "\r\n   IF ERRORCODE() THEN BREAK END" +
        //                    "\r\n   " +
        //                    "\r\nEND";
        //            break;
        //        case "TabelaSQL (Update)":
        //            text = "TabelaSQL{Prop:SQLRowSet} = 'UPDATE SET WHERE'" +
        //                    "\r\nIF ERRORCODE()" +
        //                    "\r\n   SourceMensagemTID('Erro na instrução SQL !!!||'& FILEERRORCODE() &': '&FILEERROR(),|" +
        //                    "\r\n                     'ERRO: '& ERRORCODE(),'Icon:Hand','1','1',1,'Mensagem','PEDVENDA',1,2)" +
        //                    "\r\nEND";
        //            break;
        //        case "Message TID (Warning)":
        //            text = "SourceMensagemTID('Mensagem de exemplo','Atenção',|" +
        //                    "\r\n                   'Icon:Exclamation','1','1',1,'Mensagem','PEDVENDA',1,02)";
        //            break;
        //        case "Message TID (Error)":
        //            text = "SourceMensagemTID('Mensagem de exemplo','Atenção',|" +
        //                   "\r\n                   'Icon:Hand','1','1',1,'Mensagem','PEDVENDA',1,02)";
        //            break;
        //        case "Message Case (Yes/No)":
        //            text = "Case Message('Confirma gravação?','Mensagem',|" +
        //                   "\r\n             Icon:Question,'&Sim|&Não',1,0)" +
        //                   "\r\nOF 1" +
        //                   "\r\nOF 2" +
        //                   "\r\n    DO ProcedureReturn" +
        //                   "\r\nEND";
        //            break;
        //        case "Message (Warning)":
        //            text = "Message('Mensagem de exemplo','Atenção',|" +
        //                   "\r\n             ICON:Exclamation,BUTTON:OK,BUTTON:OK,1)";
        //            break;
        //        case "Message (Error)":
        //            text = "Message('Mensagem de exemplo','Erro: ',|" +
        //                   "\r\n             ICON:Hand,BUTTON:OK,BUTTON:OK,1)";
        //            break;
        //        case "Window (Force Refresh)":
        //            text = "ForceRefresh = True" +
        //                   "\r\nLocalRequest = OriginalRequest" +
        //                   "\r\nDO RefreshWindow";
        //            break;
        //        case "Process Label (Change Text Up)":
        //            text = "(?Progress:UserString) {PROP:TEXT} = 'Carregando Ped.Nr.: '& FORMAT(LOC:NrPedido,@n7.`0)" +
        //                   "\r\nDISPLAY";
        //            break;
        //        case "Process Label (Change Text Down)":
        //            text = "(?Progress:PctText) {PROP:TEXT} = 'Ped.Nr.: '& FORMAT(LOC:NrPedido,@n7.`0)" +
        //                   "\r\nDISPLAY";
        //            break;
        //        case "Owner Database (Get)":
        //            text = "PosicaoInicial# = INSTRING(',',GLO:Owner,1,1)" +
        //                   "\r\nPosicaoFinal# = INSTRING(',',GLO:Owner,1,PosicaoInicial# + 1)" +
        //                   "\r\nLOC:DataBase = SUB(GLO:Owner,PosicaoInicial# + 1,PosicaoFinal# - PosicaoInicial# - 1) &'.DBO.'";
        //            break;
        //        case "Queue (Add Record)":
        //            text = "QUE:Descricao = 'Erro ao limpar o faturamento'" +
        //                   "\r\nGET(QUE:MarcaFaturadoErros,+QUE:Descricao)" +
        //                   "\r\nIF ERRORCODE()" +
        //                   "\r\n   QUE:Descricao = 'Erro ao limpar o faturamento'" +
        //                   "\r\n   QUE:Sequencias = ISPDATA:Sequencia" +
        //                   "\r\n   ADD(QUE:MarcaFaturadoErros,+QUE:Descricao)" +
        //                   "\r\nELSE" +
        //                   "\r\n   QUE:Sequencias = CLI(QUE:Sequencias)&', '&ISPDATA:Sequencia" +
        //                   "\r\n   PUT(QUE:MarcaFaturadoErros)" +
        //                   "\r\nEND";
        //            break;
        //        case "Column (Width Change)":
        //            text = "?Browse:1{PropList:Width,13} = 0";
        //            break;
        //        case "Column Group (Width Change)":
        //            text = "?Browse:1{PropList:Width + PropList:Group,3} = 0";
        //            break;
        //        case "Directory (Create)":
        //            text = "! COPY FILE CLIB.CLW TO APP FOLDER THEN ADD TO PROJECT" +
        //                   "\r\n! ADD TO GLOBAL EMBEDS > INSIDE GLOBAL MAP:" +
        //                   "\r\n! INCLUDE('CLIB.CLW')" +
        //                   "\r\nIF NOT EXISTS('\\TIDSCI\\EXETPS\\EMP' & FORMAT(GLO: Empresa, @n02) & '\\NFE\\EXPORT')" +
        //                   "\r\n   LOC:Diretorio = '\\TIDSCI\\EXETPS\\EMP' & FORMAT(GLO: Empresa, @n02) & '\\NFE\\EXPORT'" +
        //                   "\r\n   MKDIR(LOC:Diretorio)" +
        //                   "\r\nEND";
        //            break;
        //        case "APP (Allow only one Instance)":
        //            text = "! COPY FILE CWUTIL.INC TO APP FOLDER THEN ADD TO PROJECT" +
        //                    "\r\n! ADD TO GLOBAL EMBEDS > INSIDE GLOBAL MAP:" +
        //                    "\r\n! INCLUDE('CWUTIL.INC'),ONCE" +
        //                    "\r\nIF NOT BeginUnique('HISTFCLI.EXE')" +
        //                    "\r\n   YIELD()" +
        //                    "\r\n   CASE MESSAGE('O Histórico Financeiro já está aberto ...','Atenção',ICON: Asterisk,BUTTON: OK,BUTTON: OK,0)" +
        //                    "\r\n   OF BUTTON:OK" +
        //                    "\r\n      HALT()" +
        //                    "\r\n   END" +
        //                    "\r\nEND";
        //            break;
        //        case "Acronym (Default Test)":
        //            text = "CON1:Matricula = GLO:Matricula" +
        //                    "\r\nCON11:CodigoSistema = 'TEI'" +
        //                    "\r\nGET(ContrAcesso,CON1:OrdemMatriculaSistema)" +
        //                    "\r\nIF ERRORCODE()" +
        //                    "\r\n   MESSAGE('ATENÇÃO: Acesso Não Permitido!',| " +
        //                    "\r\n          'Sigla de Acesso: '& CON1:CodigoSistema,'\\TIDSCI\\FIGURAS\\SEMACESS.ICO',Button:OK,Button:OK,1)" +
        //                    "\r\n   DO ProcedureReturn" +
        //                    "\r\nEND" +
        //                    "\r\nSourceGravaDetalheSistema('BCR',393,'Baixa Carga Entregue','Exp.>Contr.Entregas>Mov.>Romaneio Entregas>','EXPEDICA.APP')";
        //            break;
        //        case "Record (Delete Child Record)":
        //            text = "!End of Procedure Before closing Files" +
        //                    "\r\nIF (LocalRequest = DeleteRecord AND LocalResponse = RequestCompleted) OR |" +
        //                    "\r\n   (LocalRequest = InsertRecord AND LocalResponse = RequestCancelled)" +
        //                    "\r\n   TabelaProdSQL{Prop:SQL} = 'DELETE FROM LoteFichaProducaoGenericaItens WHERE SequenciaLote = ' & LFPG:SequenciaLote" +
        //                    "\r\n   IF ERRORCODE()" +
        //                    "\r\n      SourceMensagemTID('Erro na instrução SQL !!!||' & FILEERRORCODE() & ': ' & FILEERROR(),|" +
        //                    "\r\n                        'ERRO: '& ERRORCODE(),'Icon:Hand','1','1', 1,'Mensagem','PRODGEN',1,135)" +
        //                    "\r\n   END" +
        //                    "\r\nEND";
        //            break;
        //        case "Browse (Refresh)":
        //            text = "DO BRW1::SelectSort";
        //            break;
        //        case "Queue (Read All Records)":
        //            text = "LOOP I# = 1 TO RECORDS(QUE:PedidosGerados)" +
        //                   "\r\n   GET(QUE:PedidosGerados,I#)" +
        //                   "\r\n   IF ERRORCODE() THEN BREAK END" +
        //                   "\r\n   " +
        //                   "\r\nEND";
        //            break;
        //        case "CLA Table (Key)":
        //            text = "LOC:Chave = FORMAT(GLO: Matricula, @n03) & ' ' & FORMAT(TODAY(), @D06b) & ' ' & FORMAT(CLOCK(), @T04b) & '_'" +
        //                   "\r\nRandoms# = 30 - LEN(CLIP(LOC:Chave))" +
        //                   "\r\nLOOP I# = 1 TO Randoms#" +
        //                   "\r\n   CASE(RANDOM(1,3))" +
        //                   "\r\n      OF 1" +
        //                   "\r\n         LOC:Chave = CLIP(LOC:Chave) & RANDOM(0, 9)" +
        //                   "\r\n      OF 2" +
        //                   "\r\n         LOC:Chave = CLIP(LOC:Chave) & CHR(RANDOM(97, 122))" +
        //                   "\r\n      OF 3" +
        //                   "\r\n         LOC:Chave = CLIP(LOC:Chave) & CHR(RANDOM(65, 90))" +
        //                   "\r\n   END" +
        //                   "\r\nEND";
        //            break;
        //    }
        //    return text;
        //}
    }
}
