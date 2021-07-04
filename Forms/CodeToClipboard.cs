using System;
using System.Windows.Forms;

namespace Utilities
{
    public partial class CodeToClipboard : Form
    {
        public CodeToClipboard()
        {
            InitializeComponent();
        }

        private string ClipboardText()
        {//add print line detail for a multi line text field
            string text="";
            switch (cboCodeClipboard.Text)
            {
                case "Print (Multiline String Manually) ":
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
                    text =  "TabelaSQL{Prop:SQLRowSet} = 'SELECT FROM WHERE'" +
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
                    text = "TabelaSQL{Prop:SQLRowSet} = 'UPDATE SET WHERE'" +
                            "\r\nIF ERRORCODE()" +
                            "\r\n   SourceMensagemTID('Erro na instrução SQL !!!||'& FILEERRORCODE() &': '&FILEERROR(),|" +
                            "\r\n                     'ERRO: '& ERRORCODE(),'Icon:Hand','1','1',1,'Mensagem','PEDVENDA',1,2)" +
                            "\r\nEND";
                    break;
                case "Message TID (Warning)":
                    text =  "SourceMensagemTID('Mensagem de exemplo','Mensagem',|" +
                            "\r\n                   'Icon:Exclamation','1','1',1,'Mensagem','PEDVENDA',1,02)";
                    break;
                case "Message TID (Error)":
                    text = "SourceMensagemTID('Mensagem de exemplo','Atenção',|" +
                           "\r\n                   'Icon:Hand','1','1',1,'Mensagem','PEDVENDA',1,02)";
                    break;
                case "Message Case (Yes/No)":
                    text = "Case Message('Confirma gravação?','Mensagem',|" +
                           "\r\n             'Icon:Question','&Sim|&Não',1,0)"+
                           "\r\nOF 1"+
                           "\r\nOF 2"+
                           "\r\n    DO ProcedureReturn"+
                           "\r\nEND";
                    break;
                case "Message (Warning)":
                    text = "Message('Mensagem de exemplo','Atenção',|" +
                           "\r\n             ICON:Exclamation,BUTTON:OK,BUTTON:OK,1)";
                    break;
                case "Message (Error)":
                    text = "Message('Mensagem de exemplo','Erro: ',|" +
                           "\r\n             ICON:Hand,BUTTON:OK,BUTTON:OK,1)";
                    break;
                case "Window (Force Refresh)":
                    text = "ForceRefresh = True" +
                           "\r\nLocalRequest = OriginalRequest" +
                           "\r\nDO RefreshWindow";
                    break;
                case "Process Label (Change Text Up)":
                    text = "(?Progress:UserString) {PROP:TEXT} = 'Carregando Ped.Nr.: '& FORMAT(LOC:NrPedido,@n7.`0)"+
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
                    text ="?Browse:1{PropList:Width,13} = 0";
                    break;
                case "Column Group (Width Change)":
                    text = "?Browse:1{PropList:Width + PropList:Group,3} = 0";
                    break;
            }
            return text;
        }

        private void BtnCopyClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ClipboardText());
            txtCodePreview.Text = cboCodeClipboard.Text + "\r\nCopied to clipboard successfully.";
        }
        private void ComboCodeClipboard_SelectedValueChanged(object sender, EventArgs e)
        {
            txtCodePreview.Text = "Preview:"+"\r\n"+"\r\n"+ ClipboardText();
        }
    }
}
