#region CLR�汾 4.0.30319.239
// Shell ��
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�Shell����
// ��٣�Ӧ�ó���Shell����
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		   �޸���		����
// 2012-11-23  ����         InstallSubSystem�Ż����壻
//                          1.�߱�ִ����������UninstallSubSystem������ִ�л��⣻
//                          2.�ӹ��������ж�ȡ��ϵͳ�����򴴽������빤����
//                          3.�ӹ�����ȡ��ϵͳ������
//                          4.�ɼ����ʼ����ϵͳ���Ǵ��ٴζ�ȡ���棻
//                          5.��ͼ�ظ�����ͬһ��ϵͳʱ��ִ��ˢ�²���Refresh��
//                          6.���÷���ж��InternalUninstallSubSystem��
//                          �Ż�Ҫ�������ϡ�
// 2012-11-23  ����         UninstallSubSystem�Ż����壻
//                          1.�߱�ִ����������InstallSubSystem������ִ�л��⣻
//                          2.����InternalUninstallSubSystem�Ĺ�����
//                          �Ż�Ҫ�������ϡ�
// 2012-11-23  ����         InternalUninstallSubSystem��ӣ�
//                          1.UninstallSubSystem�����幤����
//                          2.û��ִ���������ڳ����ڲ�ʹ�ã�
//                          �Ż�Ҫ�������ϡ�
// 2012-11-23  ����         GetActiveSubSystem�Ż����壻
//                          1.ͨ�����������ȡ��ϵͳ������
//                          2.Ѱַ����Ϊm_activeSpec��
//                          �Ż�Ҫ�������ϡ�
// 2012-11-23  ����         GetSubSystem�Ż����壻
//                          1.����IShellSpec����������
//                          2.����IDocument����������
//                          �Ż�Ҫ�������ϡ�                        
// 2012-11-23  ����         ShowSystem��ӣ�
//                          1.Ӧ����InstallSubSystem�����У�
//                          2.ֻ������μ��ػ���ʾ��ϵͳ�������
//                          3.ͨ���������ֳ�ʼ���뻺���ȡ�������
//                          4.���幦��������ʵ�֣�
//                          �Ż�Ҫ�������ϡ� 
// 2012-11-23  ����         HideSystem��ӣ�
//                          1.Ӧ����InstallSubSystem�����У� 
//                          2.ֻ��������Ƴ���������ϵͳ�������    
//                          3.���幦��������ʵ�֣�                  
//                          �Ż�Ҫ�������ϡ�
// 2012-11-28  ����         Record��ӣ�
//                          1.ͨ������m_formRegistry�Ĵ���Ч��ʽ��
//                          2.û������ӣ����򸲸ǣ�
//                          3.����ʹ�ã�
//                          �Ż�Ҫ�������ϡ�
// 2012-11-28  ����         RecordPurge��ӣ�
//                          1.�ӻ���m_formRegistry��������ʽ��
//                          2.ͨ��ͣ���������������
//                          3.����ʹ�ã�
//                          �Ż�Ҫ�������ϡ�
// 2012-11-28  ����         ContainsRecord��ӣ�
//                          1.�ж�m_formRegistry���Ƿ��Ѿ�ע����ͣ������
//                          2.����ʹ�ã�
//                          �Ż�Ҫ�������ϡ�
// 2012-11-28  ����         GetRecord��ӣ�
//                          1.ֱ�Ӵ�m_formRegistry��ȡ��Ч��ʽ��
//                          2.�����δע��ֱ���׳��쳣��
//                          3.����ʹ�ã�
//                          �Ż�Ҫ�������ϡ�
// 2012-11-28  ����         ShowDockWindowEx��ӣ�
//                          1.��δ����ǰ��ʽ��ʾͣ������
//                          2.����ʵ�֣�
//                          �Ż�Ҫ�������ϡ�
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.Composition;
using TDQS.Contracts;
using WinFormsUI.Docking;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using TDQS.Win32;
//using TDQS.Windows.Forms;
using TDQS.IO;
using System.Diagnostics; 

namespace TDQS.Contracts
{
    /// <summary>
    /// Ӧ�ó���Shell����
    /// </summary>
    public abstract class Shell : Form
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public Shell()
            : base()
        {
            m_activeSpec = null;
            m_factories = new Dictionary<int, SubSystemFactory>();
            m_formRegistry = new Dictionary<IntPtr, DockState>();
            #region ��� 2013-8-27 �ع� ��������ֲ
            m_dockPanel = new WinFormsUI.Docking.DockPanel();
            m_DictAssemblys = new Dictionary<string, Assembly>(); // ��ʼ�����򼯻����ֵ�
            m_GISViewCacheList = new List<DockContent>();// ����򿪵�GISView����
            #endregion
        }

        #endregion // ���������

        #region ���з���

        #region ��ϵͳװж

        /// <summary>
        /// ��װ��ϵͳ
        /// </summary>
        /// <param name="spec">��ϵͳ���</param>
        public virtual void InstallSubSystem(IShellSpec spec)
        {
            if (m_subSystemLock)
            {
                return;
            }
            m_subSystemLock = true;
            //������ϵͳ����
            SubSystemFactory factory = null;
            //�Ƿ��Ѿ���ɹ�����ʼ��
            bool initialized = true;
            //������ϵͳ
            SubSystem system = null;
            //��֧1�����Ϊ�գ��϶�ΪCMN��ϵͳ����
            if (spec == null)
            {
                if (m_activeSpec != null)
                {
                    InternalUninstallSubSystem();
                }
                if (!m_factories.ContainsKey(0))
                {
                    factory = GetSystemFactory("CMN");
                    if (factory == null)
                    {
                        m_subSystemLock = false;
                        return;
                    }
                    m_factories.Add(0, factory);
                    //���δ��ɳ�ʼ��
                    initialized = false;
                }
                else
                {
                    //��ϵͳ������ֵ
                    factory = m_factories[0];
                }
                //�л���ǰ���Ŀ¼
                XSystem.SubSystemCompositionContainer = XSystem.GetContainerByDirectory("CMN");
                //��ȡ��ϵͳ
                system = factory.GetSystemInstance(null);
                ShowSystem(system, initialized);
                m_activeSpec = null;
                m_subSystemLock = false;
                return;
            }
            //��֧2�����ǿգ����Ϊ�ջ�������һ���򷵻�
            if (m_activeSpec != null
                && spec.SubgchtypeID == m_activeSpec.SubgchtypeID)
            {
                factory = m_factories[m_activeSpec.SubgchtypeID];
                factory.Refresh();
                m_subSystemLock = false;
                return;
            }
            //��֧3��������һ�£�ж�ص�ǰ��ϵͳ
            InternalUninstallSubSystem();
            if (!m_factories.ContainsKey(spec.SubgchtypeID))
            {
                factory = GetSystemFactory(spec.ComponentsDirectory);
                if (factory == null)
                {
                    m_subSystemLock = false;
                    return;
                }
                m_factories.Add(spec.SubgchtypeID, factory);
                //ִ���˳�ʼ��
                initialized = false;
            }
            else
            {
                //��ϵͳ������ֵ
                factory = m_factories[spec.SubgchtypeID];
            }
            //�л���ǰ���Ŀ¼
            XSystem.SubSystemCompositionContainer = XSystem.GetContainerByDirectory(spec.ComponentsDirectory);
            //��ȡ��ϵͳ
            system = factory.GetSystemInstance(spec);
            //��ʾ��ϵͳ
            ShowSystem(system, initialized);
            //ʹ��system.Spec����ʹ��spec��Ϊ��ȷ��IShellSpec�����һ����
            m_activeSpec = system.Spec;
            m_subSystemLock = false;
        }

        /// <summary>
        /// ж�ص�ǰ��ϵͳ
        /// </summary>
        public virtual void UninstallSubSystem()
        {
            if (m_subSystemLock)
            {
                return;
            }
            m_subSystemLock = true;
            InternalUninstallSubSystem();
            m_subSystemLock = false;
        }

        #endregion

        #region ͣ������ʽ��¼

        /// <summary>
        /// ��¼ͣ������ʽ��¼
        /// </summary>
        /// <param name="window">����</param>
        /// <param name="excludeHidden">�Ƿ��ų��¼����״̬��Ĭ��Ϊ��</param>
        /// <returns>�Ƿ��¼�ɹ�</returns>
        public bool Record(IDockWindow window, bool excludeHidden = true)
        {
            //����Ϊ�����������¼
            if (window == null
                || window.Instance == null)
            {
                return false;
            }
            //�ų����������������¼
            if (excludeHidden &&
                (window.Instance.IsHidden || window.Instance.DockHandler.IsHidden))
            {
                return false;
            }
            //�������滻�����������
            if (!m_formRegistry.ContainsKey(window.Instance.Handle))
            {
                m_formRegistry.Add(window.Instance.Handle, window.Instance.DockState);
            }
            else
            {
                m_formRegistry[window.Instance.Handle] = window.Instance.DockState;
            }
            return true;
        }

        /// <summary>
        /// ���ͣ������ʽ��¼
        /// </summary>
        /// <param name="window">����</param>
        /// <returns>�Ƿ�����ɹ�</returns>
        public bool RecordPurge(IDockWindow window)
        {
            if (window == null
                || window.Instance == null
                || !ContainsRecord(window))
            {
                return false;
            }
            return m_formRegistry.Remove(window.Instance.Handle);
        }

        #endregion

        #region DocView

        /// <summary>
        /// ���ص�ǰ����View
        /// </summary>
        /// <returns></returns>
        public virtual IView GetActiveView()
        {
            #region ��� 2013-8-27 �ع� ��������ֲ
            return m_CurrentView;
            #endregion
        }

        /// <summary>
        /// ���ص�ǰ����Document
        /// </summary>
        /// <returns></returns>
        public virtual IDocument GetActiveDocument()
        {
            #region ��� 2013-8-27 �ع� ��������ֲ
            IDocument doc = null;

            IView view = GetActiveView();
            if (view != null)
            {
                doc = view.Document;
            }
            return doc;
            #endregion
        }

        #endregion

        /// <summary>
        /// ��ʾ��������
        /// </summary>
        public virtual void ShowWelcome()
        { 
        }

        /// <summary>
        /// ��ʾ ���̹��������
        /// </summary>
        /// <param name="switchover"></param>
        public virtual void ShowManager(DisplayType type)
        {

        }

        /// <summary>
        /// ���»��Ʋ˵�
        /// </summary>
        /// <param name="commands"></param>
        /// <param name="directory"></param>
        public virtual void AfreshDrawMenu(IEnumerable<Lazy<Action<Contracts.Shell>, ICommandMetadataView>> commands, string directory)
        {
        }
        /// <summary>
        /// ���ò˵��͹�����״̬
        /// </summary>
        /// <param name="flag"></param>
        public virtual void SetMenuState(bool flag)
        {
 
        }
        /// <summary>
        /// ��ʾDockWindow
        /// </summary>
        /// <param name="dockWindow"></param>
        public virtual void ShowDockWindow(IDockWindow dockWindow)
        {
            #region ��� �ع� 2013-8-27 ��������ֲ
            try
            {
                XDockState ds = XDockState.Document;
                if (!Enum.TryParse<XDockState>((dockWindow as DockContent).DockState.ToString(), out ds))
                {
                    ShowDockWindow(dockWindow, XDockState.Unknown);
                }
                ShowDockWindow(dockWindow, XDockState.Document);
            }
            catch (Exception ex)
            {
                string errMessage = "�л�dockWindow����";
                XSystem.LogHandler.Error(errMessage, ex);
                //[�ʼ�ع�]����20130731����ʾ���Ż�
                //MsgBox.Show(errMessage, ex.Message + Environment.NewLine + ex.StackTrace, "ϵͳ��ʾ", MsgBoxButtons.ContinueQuit);
                //MsgBox.Show("�����л�ʧ�ܣ�");
                throw ex;
            }
            #endregion
        }

        /// <summary>
        /// ��ʾDockWindow
        /// </summary>
        /// <param name="dockWindow"></param>
        /// <param name="dockState"></param>
        public virtual void ShowDockWindow(IDockWindow dockWindow, XDockState dockState)
        {
            #region ��� 2013-8-27 �ع� ��������ֲ
            try
            {
                DockState ds = DockState.Document;

                if (!Enum.TryParse<DockState>(dockState.ToString(), out ds))
                {
                    Debug.Assert(false, "ͣ��λ��ö��ת��ʧ�ܣ�#FrmMain.ShowView(IView view, XDockState dockState)#");
                }
                // Start Bug No.[        ]  (��� 2013/3/28 16:52:19)
                // ��������:  ��DockPanel��ز�����������Ż��ع�
                //            
                // �޸�˵��:  
                //            
                // ======================================================= 

                //(dockWindow as DockContent).Show(m_dockPanel, ds);

                DockContent dc = dockWindow as DockContent;

                if (dc != null)
                {
                    dc.OnBeforeClose -= dockContent_OnBeforeClose;
                    dc.OnAfterActive -= dockContent_OnAfterActive;

                    dc.OnBeforeClose += new DockContent.OnCloseHandler(dockContent_OnBeforeClose);
                    dc.OnAfterActive += new EventHandler(dockContent_OnAfterActive);
                    if (dockWindow is ICanvasView)
                    {
                        if (!m_GISViewCacheList.Contains(dc))
                        {
                            m_GISViewCacheList.Add(dc);
                        }
                    }
                    dc.Show(m_dockPanel, ds);
                }

                // End Bug No.[        ] (��� 2013/3/28 16:52:24)
            }
            catch (Exception ex)
            {
                string errMessage = "dockWindow�л�����";
                XSystem.LogHandler.Error(errMessage, ex);
                //[�ʼ�ع�]����20130731����ʾ���Ż�
                //MsgBox.Show(errMessage, ex.Message + Environment.NewLine + ex.StackTrace, "ϵͳ��ʾ", MsgBoxButtons.ContinueQuit);
                //MsgBox.Show("�����л�ʧ�ܣ�");
                throw ex;
            }
            #endregion
        }

        /// <summary>
        /// ��ʾͣ�����Ľ�
        /// </summary>
        /// <param name="window">����</param>
        public virtual void ShowDockWindowEx(IDockWindow window)
        {
            #region ��� 2013-8-27 �ع� ��������ֲ
            if (!ContainsRecord(window))
            {
                ShowDockWindow(window);
                return;
            }
            DockState state = GetRecord(window);
            if (window.Instance.DockState != state)
            {
                window.Instance.DockState = state;
            }
            if (IsDockStateAutoHide(window.Instance.DockState))
            {
                //*��Ҫ��䣬��ʹ�û���ɸ���ҳ��ȱʧ����
                window.Instance.Visible = true;
                (m_dockPanel.GetField("m_autoHideStripControl") as AutoHideStripBase).Invalidate();
            }
            #endregion
        }

        /// <summary>
        /// ��ʾView
        /// </summary>
        /// <param name="view"></param>
        public virtual void ShowView(IDockWindow view)
        {
            #region ��� 2013-8-27 �ع� ��������ֲ
            ShowDockWindow(view, XDockState.Document);
            #endregion
        }

        #region ��ʾ��ͼ

        #region �����Ż� ������, 2013/3/13 11:21:37, �޸ģ�����ͼ-��ͼ�л� ��Ӵ�ͣ��״̬����ʾ��ͼ����

        /// <summary>
        /// ��ʾ��ͼ
        /// </summary>
        /// <param name="dockWindow">��ͼ����</param>
        /// <param name="parentWindow">��ͼ��������ͼ</param>
        /// <param name="rectangle">��ͼ������ʾ��λ�úʹ�С</param>
        public virtual void ShowChildView(IDockWindow dockWindow, IDockWindow parentWindow, System.Drawing.Rectangle rectangle)
        {
            #region ��� 2013-8-27 �ع� ��������ֲ

            DockContent pContent = parentWindow as DockContent;
            DockContent cContent = dockWindow as DockContent;

            // Start Bug No.[        ]  (��� 2013/4/9 9:06:47)
            // ��������:  ��DockPanel��ز�����������Ż��ع�
            //            
            // �޸�˵��:  
            //            
            // ======================================================= 
            cContent.OnBeforeClose -= dockContent_OnBeforeClose;
            cContent.OnAfterActive -= dockContent_OnAfterActive;

            cContent.OnBeforeClose += new DockContent.OnCloseHandler(dockContent_OnBeforeClose);
            cContent.OnAfterActive += new EventHandler(dockContent_OnAfterActive);
            // End Bug No.[        ] (��� 2013/4/9 9:06:51)

            if (!cContent.IsHandleCreated)
            {
                cContent.Show(pContent.Pane, rectangle);
            }
            else
            {
                //cContent.DockHandler.ActivateWithoutFocus();
                cContent.DockHandler.Activate();
            }
            #endregion
        }

       #endregion �����Ż�

        /// <summary>
        /// ��ʾ����ͼ
        /// </summary>
        /// <param name="dockWindow">ͣ������</param>
        /// <param name="parentWindow">������</param>
        public virtual void ShowChildView(IDockWindow dockWindow,IDockWindow parentWindow)
        {
            #region ��� 2013-8-27 �ع� ��������ֲ

            DockContent pContent = parentWindow as DockContent;
            DockContent cContent = dockWindow as DockContent;

            // Start Bug No.[        ]  (��� 2013/4/9 9:06:47)
            // ��������:  ��DockPanel��ز�����������Ż��ع�
            //            
            // �޸�˵��:  
            //            
            // ======================================================= 
            if (pContent != null)
            {
                pContent.OnBeforeClose -= dockContent_OnBeforeClose;
                pContent.OnAfterActive -= dockContent_OnAfterActive;
                pContent.OnBeforeClose += new DockContent.OnCloseHandler(dockContent_OnBeforeClose);
                pContent.OnAfterActive += new EventHandler(dockContent_OnAfterActive);
            }
            cContent.OnBeforeClose -= dockContent_OnBeforeClose;
            cContent.OnAfterActive -= dockContent_OnAfterActive;
            cContent.OnBeforeClose += new DockContent.OnCloseHandler(dockContent_OnBeforeClose);
            cContent.OnAfterActive += new EventHandler(dockContent_OnAfterActive);
            // End Bug No.[        ] (��� 2013/4/9 9:06:51)

            if (pContent != null && pContent.Pane != null)
            {
                if (!pContent.IsHandleCreated)
                {
                    pContent.Show(cContent.Pane, cContent);
                }
                if (!cContent.IsHandleCreated)
                {
                    cContent.Show(pContent.Pane, pContent);
                }
                else
                {
                    //cContent.DockHandler.ActivateWithoutFocus();
                    cContent.DockHandler.Activate();
                }

                #region �����Ż� ������, 2013/3/13 11:27:08, �޸ģ�����ͼ-��ͼ�л� ɾ����ע�͵Ĵ���

                #endregion �����Ż�
                return;
            }
            cContent.Show(m_dockPanel, new System.Drawing.Rectangle(
                Cursor.Position, new System.Drawing.Size(300, 300)));

            #endregion
        }

        #endregion

        /// <summary>
        /// ͣ����
        /// </summary>
        /// <param name="dockWindow">ͣ������</param>
        /// <param name="paneTo">���</param>
        public virtual void DockTo(IDockWindow dockWindow, DockPane paneTo)
        {
            #region ��� 2013-8-27 �ع� ��������ֲ
            DockContent cContent = dockWindow as DockContent;
            cContent.DockPanel = paneTo.DockPanel;
            cContent.DockState = DockState.Document;
            cContent.DockTo(paneTo, DockStyle.Fill, paneTo.Contents.Count);
            cContent.Show();
            #endregion
        }

        /// <summary>
        /// ��ʾTreeGridWatch
        /// </summary>
        public virtual void ShowTreeGridWatch()
        {
        }

        /// <summary>
        /// ���ع�����ʵ��
        /// </summary>
        /// <returns></returns>
        public virtual IToolBoxWindow GetToolBox()
        {
            return null;
        }

        /// <summary>
        /// ��ȡ��ʷ�����ĵ�
        /// </summary>
        /// <returns></returns>
        public virtual IHistroyDocmentWindow GetHistroyDocment()
        {
            return null;
        }

        /// <summary>
        /// ���˵�
        /// </summary>
        /// <returns></returns>
        public virtual MenuStrip GetMainMenuStrip(string name)
        {
            return null;
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        public virtual ToolStripPanel GetMainToolStrip(string name)
        {
            return null;
        }

        /// <summary>
        /// ��ǰ������ϵͳ
        /// </summary>
        /// <returns>��ϵͳ</returns>
        public virtual SubSystem GetActiveSubSystem()
        {
            if (m_activeSpec == null)
            {
                if (!m_factories.ContainsKey(0))
                {
                    return null;
                }
                return m_factories[0].GetSystemInstance(m_activeSpec);
            }
            if (!m_factories.ContainsKey(m_activeSpec.SubgchtypeID))
            {
                return null;
            }
            return m_factories[m_activeSpec.SubgchtypeID].GetSystemInstance(m_activeSpec);
        }

        /// <summary>
        /// ������ϵͳ����ȡ��Ӧ����ϵͳ
        /// </summary>
        /// <param name="spec">���</param>
        /// <returns>��ϵͳ</returns>
        public SubSystem GetSubSystem(IShellSpec spec)
        {
            if (spec == null
                || !m_factories.ContainsKey(spec.SubgchtypeID))
            {
                return null;
            }
            return m_factories[spec.SubgchtypeID].GetSystemInstance(spec);
        }

        /// <summary>
        /// �����ĵ������ȡ��Ӧ����ϵͳ
        /// </summary>
        /// <param name="document">�ĵ�</param>
        /// <returns>��ϵͳ</returns>
        public SubSystem GetSubSystem(IDocument document)
        {
            if (document == null)
            {
                return null;
            }
            return GetSubSystem(document.Spec);
        }

        /// <summary>
        /// ���̹�����
        /// </summary>
        /// <returns></returns>
        public virtual IProjectManagerFrm GetProjectManager()
        {
            return null;
        }

        /// <summary>
        /// ��Shell�����ToolStrip
        /// </summary>
        /// <param name="Strip">������</param>
        /// <returns>�Ƿ�ɹ�</returns>
        public virtual bool AddToolStrip(string SubSystemName,ToolStrip Strip, int row)
        {
            return false;
        }


        /// <summary>
        /// �������Դ�ʵ��
        /// </summary>
        /// <returns></returns>
        public virtual IPropertyGrid GetPropertyGrid()
        {
            return null;
        }

        /// <summary>
        /// ���ط���ѡ��������ʵ��
        /// </summary>
        /// <returns></returns>
        public virtual IToolWindow GetFilterSelectResult()
        {
            return null;
        }

        /// <summary>
        /// ����վ��ͼ����ʵ��
        /// </summary>
        /// <returns></returns>
        public virtual ISubViewContainer GetSubViewContainer()
        {
            return null;
        }


        /// <summary>
        /// ���ص�ǰ����DockWindow
        /// </summary>
        /// <returns></returns>
        public virtual IDockWindow GetActiveDockWindow()
        {
            return null;
        }

        /// <summary>
        /// ���ص�ǰdockPanel
        /// </summary>
        /// <returns></returns>
        public virtual DockPanel GetDockPanel()
        {
            #region ��� 2013-8-27 �ع� ��������ֲ
            return this.m_dockPanel;
            //return null;
            #endregion
        }

        /// <summary>
        /// �������Form����
        /// </summary>
        /// <returns>Form����</returns>
        public IEnumerable<Lazy<IForm, IFormMetadataView>> GetForms()
        {
            return Forms.Where(c => c.Metadata.ItemType == "Form");
        }

        /// <summary>
        /// �������ToolWindow����
        /// </summary>
        /// <returns>ToolWindow����</returns>
        public IEnumerable<Lazy<IToolWindow, IFormMetadataView>> GetToolWindows()
        {
            return ToolWindows.Where(c => c.Metadata.ItemType == "ToolWindow");
        }

        /// <summary>
        /// �������TreeGridWatch����
        /// </summary>
        /// <returns>TreeGridWatch����</returns>
        public IEnumerable<Lazy<ITreeGridWatch, IFormMetadataView>> GetTreeGridWatchs()
        {
            return TreeGridWatchs.Where(c => c.Metadata.ItemType == "TreeGridWatch");
        }

        ///// <summary>
        ///// ������з��񼯺�
        ///// </summary>
        ///// <returns>���񼯺�</returns>
        //public IEnumerable<Lazy<IService, IServiceMetadataView>> GetServices() { return Services; }

        /// <summary>
        /// ����Form Name���� Formʵ��
        /// </summary>
        /// <param name="name">Form Name</param>
        /// <returns>Form����</returns>
        public IForm GetForm(string name)
        {
            IEnumerable<Lazy<IForm, IFormMetadataView>> forms = GetForms();
            return forms.Where(c => c.Metadata.Name == name).First().Value;
        }

        /// <summary>
        /// �������Ʒ���ToolWindow
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IToolWindow GetToolWindow(string name)
        {
            IEnumerable<Lazy<IToolWindow, IFormMetadataView>> toolWindows = GetToolWindows();
            return toolWindows.Where(c => c.Metadata.Name == name).First().Value;
        }

        /// <summary>
        /// ����TreeGridWatch Name����TreeGridWatchʵ��
        /// </summary>
        /// <param name="name">TreeGridWatch Name</param>
        /// <returns>TreeGridWatch����</returns>
        public ITreeGridWatch GetTreeGridWatch(string name)
        {
            IEnumerable<Lazy<ITreeGridWatch, IFormMetadataView>> treeGridWatchs = GetTreeGridWatchs();
            return treeGridWatchs.Where(c => c.Metadata.Name == name).First().Value;
        }

        /// <summary>
        /// Shell �˳�
        /// </summary>
        public abstract void Exit();


        /// <summary>
        /// ����UI
        /// </summary>
        public virtual void UpdateUI()
        {
            #region ��� 2013-8-27 �ع� ��������ֲ
            try
            {
                SubSystem sub = GetActiveSubSystem();
                if (sub != null)
                {
                    SubSystemFactory subFactory = sub.SubSystemFactory;
                    if (subFactory != null && subFactory.FunctionActions.Count > 0)
                    {
                        string directory = sub.Name;

                        List<FunctionAction> listCategory = subFactory.FunctionActions.Where(c => c.FuncStruct.Type == FunctionType.Category).ToList();
                        UpdateUICategory(listCategory, directory);

                        List<FunctionAction> listItem = subFactory.FunctionActions.Where(c => c.FuncStruct.Type == FunctionType.Item).ToList();
                        UpdateUIItem(listItem, directory);
                    }
                }
            }
            catch (Exception ex)
            {
                string errMessage = "���½���Ԫ��ʧ�ܣ�";
                XSystem.LogHandler.Error(errMessage, ex);
                //MsgBox.Show(errMessage, ex.Message + Environment.NewLine + ex.StackTrace, "ϵͳ��ʾ", MsgBoxButtons.ContinueQuit);
                throw ex;
            }
            #endregion
        }


        // Code Analysis End(������ 2012/10/24 10:29:32)

        /// <summary>
        /// �ڲ�ʹ�õ�ж����ϵͳ���̣���������ϵͳ��
        /// </summary>
        internal void InternalUninstallSubSystem()
        {
            //��֧1��������Ϊ��
            if (m_activeSpec == null)
            {
                if (m_factories.ContainsKey(0))
                {
                    //����CMN��ϵͳ
                    HideSystem(m_factories[0].GetSystemInstance(null));
                }
                return;
            }
            //��֧2��������ǿգ�������ϵͳ
            HideSystem(m_factories[m_activeSpec.SubgchtypeID].GetSystemInstance(m_activeSpec));
            //��ǰ����ÿ�
            m_activeSpec = null;
        }

        #endregion // ���з���

        #region ��������

        /// <summary>
        /// ͨ�����Ŀ¼��ȡ��ϵͳ����
        /// </summary>
        /// <param name="directory">Ŀ¼</param>
        /// <returns>��ϵͳ����</returns>
        protected SubSystemFactory GetSystemFactory(string directory)
        {
            CompositionContainer container = XSystem.GetContainerByDirectory(directory);
            IEnumerable<Lazy<SubSystemFactory, ISubSystemMetadataView>> exports =
                container.GetExports<SubSystemFactory, ISubSystemMetadataView>()
                .Where(c => c.Metadata.Name.ToUpper() == directory.ToUpper());
            if (exports.Count() < 1)
            {
                return null;
            }
            return exports.First().Value;
        }

        /// <summary>
        /// ��ʾ��ϵͳ�����ʵ�����������
        /// </summary>
        /// <param name="system">��ϵͳ</param>
        /// <param name="initialized">�Ƿ�Ϊ��ʼ����ʾ</param>
        protected virtual void ShowSystem(SubSystem system, bool initialized)
        {
        }

        /// <summary>
        /// ������ϵͳ�����ʵ�����������
        /// </summary>
        /// <param name="system">��ϵͳ</param>
        protected virtual void HideSystem(SubSystem system)
        {
        }

        /// <summary>
        /// �鿴�Ƿ����ͣ������ʽ��¼
        /// </summary>
        /// <param name="window">����</param>
        /// <returns>�Ƿ����</returns>
        protected bool ContainsRecord(IDockWindow window)
        {
            if (window == null
                || window.Instance == null)
            {
                return false;
            }
            return m_formRegistry.ContainsKey(window.Instance.Handle);
        }

        /// <summary>
        /// ��ȡͣ������ʽ��¼
        /// </summary>
        /// <param name="window">����</param>
        /// <returns>��¼</returns>
        protected DockState GetRecord(IDockWindow window)
        {
            return m_formRegistry[window.Instance.Handle];
        }

        #region ��� 2013-8-27 �ع� ��������ֲ

        /// <summary>
        /// ��ͼ���弤��󴥷��¼�
        /// </summary>
        /// <param name="sender">����Ĵ���</param>
        /// <param name="e">�¼�����</param>
        protected abstract void dockContent_OnAfterActive(object sender, EventArgs e);

        /// <summary>
        /// ��ͼ����ر�ǰ�������¼�
        /// </summary>
        /// <param name="Content">����</param>
        /// <param name="e">�¼�����</param>
        protected abstract void dockContent_OnBeforeClose(IDockContent Content, CloseEventArgs e);

        #endregion

        #endregion // ��������

        #region ��������

        #region ���ִ��弯��

        /// <summary>
        /// ���Form����
        /// </summary>
        //[ImportMany(AllowRecomposition = true)]
        protected IEnumerable<Lazy<IForm, IFormMetadataView>> Forms = null;

        /// <summary>
        /// ���ToolWindow����
        /// </summary>
        //[ImportMany(AllowRecomposition = true)]
        protected IEnumerable<Lazy<IToolWindow, IFormMetadataView>> ToolWindows = null;

        /// <summary>
        /// ���TreeGridWatch����
        /// </summary>
        //[ImportMany(AllowRecomposition = true)]
        protected IEnumerable<Lazy<ITreeGridWatch, IFormMetadataView>> TreeGridWatchs = null;

        //[ImportMany(AllowRecomposition = true)]
        //protected Lazy<IService, IServiceMetadataView>[] Services = null;

        #endregion

        #endregion // ��������

        #region ˽�з���

        /// <summary>
        /// ��ʼ��
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Shell
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "Shell";
            this.ResumeLayout(false);
        }

        #region ��� 2013-8-27 �ع� ��������ֲ

        /// <summary>
        /// ����UI����Ԫ��(Menu,Toolbar,ContextMenu)
        /// </summary>
        /// <param name="subFactory">��ϵͳUI������</param>
        /// <param name="directory">��ϵͳ�ļ���</param>
        private void UpdateUICategory(List<FunctionAction> funcCategroyAll, string directory)
        {
            try
            {
                foreach (FunctionAction fa in funcCategroyAll)
                {
                    System.Windows.Forms.Control obj = fa.FuncStruct.Handler as System.Windows.Forms.Control;
                    {
                        if (fa.FuncStruct.VisibleFunction != null && fa.FuncStruct.VisibleFunction.Length > 0)
                        {
                            obj.Visible = CallMethod(directory, fa.FuncStruct.Namespace, fa.FuncStruct.VisibleFunction);
                            if (obj is ToolStrip && !obj.Capture && !VirtualKeyStates.VK_LBUTTON.IsPressed())
                            {
                                ToolStripPanelRow row = (obj as ToolStrip).GetRow();
                                if (row != null && (obj as ToolStrip).IndexOf() == row.Controls.Length - 1 && row.IsLeftGapped())
                                {
                                    row.CloseLeft();
                                }
                            }
                        }
                        if (fa.FuncStruct.EnableFunction != null && fa.FuncStruct.EnableFunction.Length > 0)
                        {
                            obj.Enabled = CallMethod(directory, fa.FuncStruct.Namespace, fa.FuncStruct.EnableFunction);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //���� 2013-08-15 
                throw new Exception("����Menu��Toolbar��ContextMenuԪ��ʧ�ܣ�������������ļ�.[" + ex.Message + "]");
            }

        }

        /// <summary>
        /// ����UIԪ��
        /// </summary>
        /// <param name="funcAll">�����Ѱ�װ����</param>
        /// <param name="directory">��ϵͳ�ļ���</param>
        private void UpdateUIItem(List<FunctionAction> funcItemAll, string directory)
        {
            try
            {
                foreach (FunctionAction fa in funcItemAll)
                {
                    dynamic obj = fa.FuncStruct.Handler;
                    {
                        if (fa.FuncStruct.CheckFunction != null && fa.FuncStruct.CheckFunction.Length > 0)
                        {
                            obj.Checked = CallMethod(directory, fa.FuncStruct.Namespace, fa.FuncStruct.CheckFunction);
                        }

                        if (fa.FuncStruct.EnableFunction != null && fa.FuncStruct.EnableFunction.Length > 0)
                        {
                            obj.Enabled = CallMethod(directory, fa.FuncStruct.Namespace, fa.FuncStruct.EnableFunction);
                        }

                        if (fa.FuncStruct.VisibleFunction != null && fa.FuncStruct.VisibleFunction.Length > 0)
                        {
                            obj.Visible = CallMethod(directory, fa.FuncStruct.Namespace, fa.FuncStruct.VisibleFunction);
                            if (obj is ToolStrip && !obj.Capture && !VirtualKeyStates.VK_LBUTTON.IsPressed())
                            {
                                ToolStripPanelRow row = (obj as ToolStrip).GetRow();
                                if (row != null && (obj as ToolStrip).IndexOf() == row.Controls.Length - 1 && row.IsLeftGapped())
                                {
                                    row.CloseLeft();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //���� 2013-08-15 
                throw new Exception("���½���Ԫ�ص�Check��Enable����ʧ�ܣ�������������ļ�.[" + ex.Message + "]");
            }

        }

        /// <summary>
        /// ��̬����UI��̬����
        /// </summary>
        /// <param name="directory">��ϵͳ�ļ���</param>
        /// <param name="directory">�����������ռ�</param>
        /// <param name="name">������</param>
        /// <returns>ִ���Ƿ�ɹ�</returns>
        private bool CallMethod(string directory, string namespacestr, string name)
        {
            string dllname;

            if (!string.IsNullOrEmpty(namespacestr))
            {
                dllname = namespacestr;
            }
            else
            {
                dllname = "TDQS." + directory.ToUpper();
            }

            String assemblyFullName = XSystem.ConfigService.PathHandler.BaseDirectory + directory + "\\" + dllname + ".dll";
            Assembly lObjAssembly = null;
            if (m_DictAssemblys.ContainsKey(assemblyFullName))
            {
                lObjAssembly = m_DictAssemblys[assemblyFullName];
            }
            else
            {
                m_DictAssemblys[assemblyFullName] = Assembly.LoadFile(assemblyFullName);
                lObjAssembly = m_DictAssemblys[assemblyFullName];
            }

            Type type = lObjAssembly.GetType(dllname + "." + "Function");
            if (type == null)
            {
                return false;
            }
            return (bool)type.InvokeMember(name, BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, new object[] { });
        }

        #endregion

        #endregion // ˽�з���

        #region ��̬����
        #region ��� 2013-8-27 �ع� ��������ֲ
        /// <summary>
        /// ���ͣ��״̬�Ƿ�Ϊ�Զ�����
        /// </summary>
        /// <param name="dockState">ͣ��״̬</param>
        /// <returns>�Ƿ�Ϊ�Զ�����</returns>
        internal static bool IsDockStateAutoHide(DockState dockState)
        {
            return dockState == DockState.DockLeftAutoHide ||
                dockState == DockState.DockRightAutoHide ||
                dockState == DockState.DockTopAutoHide ||
                dockState == DockState.DockBottomAutoHide;
        }
        #endregion

        #endregion

        #region ���Լ���˽�б���

        #region ���̹���

        /// <summary>
        /// ����ϵͳ�򿪵Ĺ���
        /// </summary>
        public IProjectManager ProjectManager = null;

        /// <summary>
        /// ���繤�̹�����
        /// </summary>
        public IProjectManager OnlineProjectManager = null;

        /// <summary>
        /// �������Ŀ
        /// </summary>
        public IProject ActiveProject
        {
            get
            {
                return ActiveProjectManager.GetActiveProject();
            }
        }

        #endregion

        /// <summary>
        /// ϵͳ��Ӧ���̳߳�
        /// </summary>
        public IAppThreadPool ApplicationThreadPool = null;

        /// <summary>
        /// ����򿪵���Ŀ������
        /// </summary>
        public ToolStripMenuItem m_projectsItem;

        /// <summary>
        /// ��ȡ�����ý����ļ���¼·��
        /// </summary>
        public string RecentFilesRecord
        {
            get
            {
                return m_recentFilesRecord;
            }
            set
            {
                if (m_recentFilesRecord == value)
                {
                    return;
                }
                m_recentFilesRecord = value;
            }
        }
        private string m_recentFilesRecord = @"Config\RecentFiles.xml";

        /// <summary>
        /// ��ȡ��������Ӧ���ļ���չ��
        /// </summary>
        public string FileExtension
        {
            get
            {
                return m_fileExtension;
            }
            set
            {
                if (m_fileExtension == value)
                {
                    return;
                }
                m_fileExtension = value;
            }
        }
        private string m_fileExtension = "*";

        #region ״̬��

        /// <summary>
        /// ״̬����Ϣ 20111116 ������
        /// </summary>
        public ITaskMonitor TaskMonitor
        {
            get
            {
                return this.m_TaskMonitor;
            }
            set
            {
                this.m_TaskMonitor = value;
            }
        }
        /// <summary>
        /// ���������
        /// </summary>
        private ITaskMonitor m_TaskMonitor;

        /// <summary>
        /// ���������� 20111116 ������
        /// </summary>
        public ICoordinateOptions CoordinateOptions
        {
            get
            {
                return this.m_CoordinateOptions;
            }
            set
            {
                this.m_CoordinateOptions = value;
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        private ICoordinateOptions m_CoordinateOptions;

        /// <summary>
        /// ״̬��������������ť���� 20111117 ������
        /// </summary>
        public IStatusStripAuxiliaryArea StatusStripAuxiliaryArea
        {
            get
            {
                return this.m_AuxArea;
            }
            set
            {
                this.m_AuxArea = value;
            }
        }
        /// <summary>
        /// ״̬����
        /// </summary>
        private IStatusStripAuxiliaryArea m_AuxArea;

        #endregion

        #region ����

        /// <summary>
        /// ����
        /// </summary>
        private ICanvas m_Canvas;

        /// <summary>
        /// ����
        /// </summary>
        public ICanvas Canvas
        {
            get
            {
                return m_Canvas;
            }
            set
            {
                m_Canvas = value;
            }
        }

        #endregion


        /// <summary>
        /// ��û����õ�ǰ�ļ�·��
        /// </summary>
        public string CurrentFile
        {
            get;
            set;
        }

        /// <summary>
        /// ��ʾ״̬
        /// </summary>
        public int m_isShow = 1;

        /// <summary>
        /// �Զ���ͣ��λ��ö��
        /// </summary>
        public enum XDockState
        {
            /// <summary>
            /// δ֪
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// ����
            /// </summary>
            Float = 1,

            /// <summary>
            /// ���Զ�����
            /// </summary>
            DockTopAutoHide = 2,

            /// <summary>
            /// ���Զ�����
            /// </summary>
            DockLeftAutoHide = 3,

            /// <summary>
            /// ���Զ�����
            /// </summary>
            DockBottomAutoHide = 4,

            /// <summary>
            /// ���Զ�����
            /// </summary>
            DockRightAutoHide = 5,

            /// <summary>
            /// �ĵ�
            /// </summary>
            Document = 6,

            /// <summary>
            /// ��
            /// </summary>
            DockTop = 7,

            /// <summary>
            /// ��
            /// </summary>
            DockLeft = 8,

            /// <summary>
            /// ��
            /// </summary>
            DockBottom = 9,

            /// <summary>
            /// ��
            /// </summary>
            DockRight = 10,

            /// <summary>
            /// ����
            /// </summary>
            Hidden = 11,
        }

        #region �ṹ�Ż���׷��

        /// <summary>
        /// ���������ϵͳ���Ĭ��ֵΪnull����ʾû�м����κ���ϵͳ
        /// </summary>
        private IShellSpec m_activeSpec;

        /// <summary>
        /// ��ϵͳ�������棬����ϵͳ������ν��ֵ���мĴ�
        /// </summary>
        private Dictionary<int, SubSystemFactory> m_factories;

        /// <summary>
        /// ������ʽע���
        /// </summary>
        private Dictionary<IntPtr, DockState> m_formRegistry;  

        /// <summary>
        /// ��ȡ����Ĺ��̹�����������
        /// </summary>
        public IProjectManager ActiveProjectManager
        {
            get
            {
                return ProjectManager;
            }
        }

        #endregion

        /// <summary>
        /// ��ȡ���̹���������
        /// </summary>
        public abstract IProjectManagerFrm ProjectManagerForm
        {
            get;
        }

        /// <summary>
        /// ���ز�������
        /// ����20131114��Document�����а�Ǩ
        /// </summary>
        /// <returns>��������</returns>
        public  IParameterCache ParameterObject
        {
            get
            {
                return m_parameterCache;
            }
        }

        protected IParameterCache m_parameterCache;

        protected IDatabase m_database;

        /// <summary>
        /// ���ݿ����
        /// </summary>
        public IDatabase Database
        {
            get { return m_database; }
        }


        /// <summary>
        /// ��ϵͳ������������������ϵͳװ��ж�صĻ���
        /// </summary>
        private bool m_subSystemLock = false;

        #region ��� 2013-8-27 �ع� ��������ֲ



        protected WinFormsUI.Docking.DockPanel m_dockPanel;

        /// <summary>
        /// ��ǰ�������ͼ
        /// </summary>
        protected IView m_CurrentView = null;

        /// <summary>
        /// ��ǰ��ʾ��GISView�Ļ���
        /// </summary>
        protected List<DockContent> m_GISViewCacheList = null;

        /// <summary>
        /// ���򼯻����ֵ�
        /// </summary>
        private Dictionary<String, Assembly> m_DictAssemblys = null;



        #endregion

        #endregion // ���Լ���˽�б���
    }
}