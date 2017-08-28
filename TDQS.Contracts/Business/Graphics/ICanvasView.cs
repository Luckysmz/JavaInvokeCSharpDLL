#region CLR�汾 4.0.30319.239
// ICanvasView �ӿ�
// ʱ�䣺2011-12-6 13:25:08
// ���ƣ�ICanvasView
// ��٣�������ͼ
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//     ����		               �޸���   ����
//1��2011��12��08��   ������   ���Ӷ���Ұ�����Ķ���
//2��2012��06��25��   ������   ���ӷ���ѡ������Ķ���

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;

namespace TDQS.Contracts
{
    /// <summary>
    /// ������ͼ�ӿ�
    /// </summary>
    public interface ICanvasView : IView
    {
        #region ����

        #region ��Ұ

        /// <summary>
        /// ��ʼ����Ұ����
        /// </summary>
        void InitialVisionMng();

        /// <summary>
        /// ������Ұ����
        /// </summary>
        void SaveVisionMng();

        /// <summary>
        /// ��ʾǰ����ͼ
        /// </summary>
        /// <returns>�Ƿ����ǰ��</returns>
        bool Previous();

        /// <summary>
        /// ��ʾ����ͼ
        /// </summary>
        /// <returns>�Ƿ������</returns>
        bool Next();

        /// <summary>
        /// ����ȫ��
        /// </summary>
        void FullExtent();

        /// <summary>
        /// ��ͼȫ��
        /// </summary>
        void FullMapExtent();

        /// <summary>
        /// ������Ұ��Ϣ
        /// </summary>
        /// <returns></returns>
        bool LoadVisionInfo();

        #endregion

        #region ����

        /// <summary>
        /// �ı��С�������ͼ��ƽ̨�ṩ�������
        /// </summary>
        /// <param name="resizedItems"></param>
        /// <param name="old"></param>
        /// <param name="newP"></param>
        /// <param name="handle"></param>
        void ResizeCommand(IDrawObject resizedItems, PointF old, PointF newP, int handle);

        /// <summary>
        /// �ƶ��������ͼ��ƽ̨�ṩ�������
        /// </summary>
        /// <param name="movedItemsList"></param>
        /// <param name="delta"></param>
        void MoveCommand(IList<object> movedItemsList, PointF delta);

        /// <summary>
        /// ����ʵ�����ƻ�ö�Ӧ����������
        /// </summary>
        /// <param name="InstanceName">Ԫ��ʵ������</param>
        /// <returns>��������</returns>
        string GetCommandName(string InstanceName);

        #endregion

        #region ����

        /// <summary>
        /// �ղ���
        /// </summary>
        void BlankTool(bool clearSelection=true);

        /// <summary>
        /// ����
        /// </summary>
        void CutTool();

        /// <summary>
        /// �ƶ�
        /// </summary>
        void MoveTool();

        /// <summary>
        /// ����
        /// </summary>
        void PathTool();

        /// <summary>
        /// ·������
        /// </summary>
        void PathChangeTool();

        /// <summary>
        /// ����
        /// </summary>
        void CopyTool();

        /// <summary>
        /// ճ��
        /// </summary>
        void PasteTool();

        /// <summary>
        /// ճ����ԭ����
        /// </summary>
        void PasteToTool();


        /// <summary>
        /// ���
        /// </summary>
        /// <param name="bUnGroup">�Ƿ�ȡ��</param>
        void GroupTool(bool bUnGroup = false);
        
        /// <summary>
        /// ɾ��
        /// </summary>
        void DeleteTool();

        /// <summary>
        /// ȫѡ
        /// </summary>
        void SelectAllTool();

        /// <summary>
        /// �����ƶ��Ĳ�������
        /// </summary>
        /// <param name="aToolName">����������</param>
        /// <param name="isPersistence">�Ƿ���������</param>
        void SequenceActiveTool(string aToolName, bool isPersistence = false);

        /// <summary>
        /// �����ƶ��Ĳ�������
        /// </summary>
        /// <param name="aTool">��������</param>
        /// <param name="isPersistence">�Ƿ�����</param>
        void SequenceActiveTool(IToolObject aTool, bool isPersistence = false);

        #endregion

        /// <summary>
        /// ���ģ�����
        /// </summary>
        /// <param name="tempID">ģ��ID</param>
        /// <returns></returns>
        object GetTempObj(string tempID);

        /// <summary>
        /// ��������ͼ
        /// </summary>
        /// <param name="Sub">����������</param>
        /// <returns>�Ƿ�ɹ�����</returns>
        bool ActiveSubView(IElement Sub);

        /// <summary>
        /// չʾԪ������
        /// </summary>
        /// <param name="ele"></param>
        void ShowElementProperty(IElement ele);

        /// <summary>
        /// ��ʾע��
        /// </summary>
        void ShowNote();

        /// <summary>
        /// �Ѱ���ѡ��
        /// </summary>
        /// <returns></returns>
        bool IsSelection();

        /// <summary>
        /// ����CAD�ļ�
        /// </summary>
        bool ExportDXF();

        /// <summary>
        /// ����PIC�ļ�
        /// </summary>
        /// <returns></returns>
        bool ExportPIC();
        
        /// <summary>
        /// Ԫ�����Ϊģ��
        /// </summary>
        /// <returns></returns>
        bool ElementSaveToTemplate();

        #region Renderable

        /// <summary>
        /// ��ָ��ID������ɫ
        /// </summary>
        /// <param name="ids">id����</param>
        /// <param name="color">��ɫ</param>
        void SetColor(ICollection<string> ids, System.Drawing.Color color);

        /// <summary>
        /// ��ָ��ID������ɫ
        /// </summary>
        /// <param name="ids">id����</param>
        /// <param name="color">��ɫ</param>
        /// <param name="isSetParentColor">�Ƿ�Ը��豸Ⱦɫ</param>
        void SetColor(ICollection<string> ids, System.Drawing.Color color, bool isSetParentColor);

        /// <summary>
        /// �ָ�Ĭ����ʽ
        /// </summary>
        void Recover();
        /// <summary>
        /// �ָ�ָ��Ԫ������Ĭ����ʽ
        /// </summary>
        /// <param name="elements"></param>
        void Recover(List<IElement> elements);
        /// <summary>
        /// ˢ��
        /// </summary>
        void Refresh();

        #endregion

        #region MapControlable

        #region ��λ

        /// <summary>
        /// Ԫ��ID��λ
        /// </summary>
        /// <param name="ElementID">ID��λ</param>
        void Locate(string ElementID, bool isAddSelection = true);

        /// <summary>
        /// Ԫ��ID���϶�λ
        /// </summary>
        /// <param name="sIDCollection">ID����</param>
        void Locate(ICollection<string> sIDCollection, bool isAddSelection = true);

        #endregion

        #region ��˸

        /// <summary>
        /// ��˸ָ��ID��ʵ��
        /// </summary>
        /// <param name="id">����˸ʵ��ID</param>
        /// <param name="nFlashes">��˸����</param>
        /// <param name="flashInterval">ÿ����˸ʱ�䣬��λΪ����</param>
        void LocateAndFlash(string id, int nFlashes, int flashInterval);

        /// <summary>
        /// ��˸ָ��ID��ʵ��
        /// </summary>
        /// <param name="ids">����˸ʵ��ID����</param>
        /// <param name="nFlashes">��˸����</param>
        /// <param name="flashInterval">ÿ����˸ʱ�䣬��λΪ����</param>
        void LocateAndFlash(ICollection<string> ids, int nFlashes, int flashInterval);

        #endregion

        #endregion

        #endregion // ����

        #region ����

        #region Ԫ��

        /// <summary>
        /// Ԫ������ (��ǰ��ͼ�е�Ԫ������,����ǵ���ͼΪ�������ϣ��������ͼΪ��Ԫ������)
        /// </summary>
        IElementCollection ElementCollection 
        { 
            get; 
        }

        /// <summary>
        /// Ԫ���������
        /// </summary>
        IElementHandler ElementHandler 
        { 
            get; 
        }

        /// <summary>
        /// ToolBox�е�ǰ�����Ԫ��ԭ��
        /// </summary>
        string ActiveElement 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// ToolBox�е�ǰ�����Ԫ������
        /// </summary>
        ElementType ActiveElementType 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// ToolBox�е�ǰ�����Ԫ��ʵ��ID
        /// </summary>
        string ActiveElementID
        {
            get;
            set;
        }

        /// <summary>
        /// ��ȡ����ͼ����Ӧ�ĵ���Ԫ�������
        /// </summary>
        IElement ViewRoot
        {
            get;
            set;
        }

        /// <summary>
        /// ����Ԫ��
        /// </summary>
        IElementBuilder ElementBuilder
        {
            get;
            set;
        }

        #endregion

        /// <summary>
        /// ��û����ÿؼ�������ɫ
        /// </summary>
        Color BackGroundColor 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// ����
        /// </summary>
        ICanvas Canvas 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// ����������ջ
        /// </summary>
        IUndoRedo UndoRedo 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// ��Ұ�������
        /// </summary>
        IVisionBusiness VisionMng 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// ����ͼ�������
        /// </summary>
        IBackgroundBusiness BackgroundBusiness 
        { 
            get; 
            set; 
        }

        #region ����

        /// <summary>
        /// �����Tool
        /// </summary>
        IToolObject ActiveTool 
        { 
            get; 
            set; 
        }

        /// <summary>
        /// Ĭ�ϵ�ָʾ��Tool
        /// </summary>
        IToolObject DefaultTool 
        { 
            get; 
            set; 
        }

        #endregion

        /// <summary>
        /// ������ͼ��ʾ����
        /// </summary>
        CanvasViewOpenType CanvasViewOpenType 
        { 
            get; 
        }

        /// <summary>
        /// ��ǰ��ͼ��Ұ��
        /// </summary>
        string CurrentVisionName
        {
            get;
            set;
        }

        #region �̶�����״̬

        // TODO: Code Analysis Start(������ 2012/10/26 16:38:46)
        // ����: [Υ����չԭ��] 
        // ���س̶�: [ 2 ] ��1:�ǳ�����  2:���� 3:һ�㣩 
        // ��ϸ˵��:  
        // ��Щboolֵ�ĺ��壬�Ƿ�Ҫ��view�Ͽ��š�           
        // ======================================================= 
        //  ����		   �޸���	    	���� 

        /// <summary>
        /// �Ƿ����ƶ�
        /// </summary>
        bool bMove
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ����ճ��
        /// </summary>
        bool bPaste
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ����ճ����ԭ����
        /// </summary>
        bool bPasteTo
        {
            get;
            set;
        }


        /// <summary>
        /// �Ƿ��������
        /// </summary>
        bool bPath
        {
            get;
            set;
        }

 
        /// <summary>
        /// ·������
        /// </summary>
        bool bPathChange
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ�������ɾ��ģʽ
        /// </summary>
        bool bContinuateDelete
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ�ɾ��
        /// </summary>
        bool bDelete
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ����
        /// </summary>
        bool bGroup
        {
            get;
            set;
        }

        // Code Analysis End(������ 2012/10/26 16:38:54)

        #endregion
       
        #region ����ѡ��

        /// <summary>
        /// Ԫ�������ֵ�
        /// </summary>
        Dictionary<ElementType, string> ElementTypes
        {
            get;
        }

        /// <summary>
        /// ��ǰ��ͼ�ܱ�ѡ���Ԫ������
        /// </summary>
        List<ElementType> SelectedElementTypes
        {
            get;
            set;
        }

        /// <summary>
        /// ��ǰ��ͼ�ܱ�ѡ���Ԫ������
        /// </summary>
        ElementType SelectedElementType
        {
            get;
            set;
        }

        /// <summary>
        /// Ԫ��ѡ��ʽ
        /// </summary>
        FilerType ElementFilerType
        {
            get;
            set;
        }

        /// <summary>
        /// ���˿���
        /// </summary>
        bool FilterSwitch
        {
            get;
            set;
        }

        /// <summary>
        /// tip��ʾ����
        /// </summary>
        bool TipDis
        {
            get;
            set;
        }
        
        #endregion

        /// <summary>
        /// ��ѡ�е�ͼԪ
        /// </summary>
        List<FeatureLite> SelectedFeatures
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ���ʾ��ע
        /// </summary>
        bool IsNoteShow
        {
            get;
            set;
        }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

