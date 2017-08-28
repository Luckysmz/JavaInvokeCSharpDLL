#region CLR�汾 4.0.30319.269
// SubSystemFactory ��
// ʱ�䣺2012-5-16 15:43:48
// ���ƣ�SubSystemFactory
// ��٣���ϵͳ������
//
// �����ˣ�����
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.ComponentModel.Composition;

namespace TDQS.Contracts
{
    /// <summary>
    /// ��ϵͳ������
    /// </summary>
    public abstract class SubSystemFactory
    {
        #region ���������
        #endregion // ���������

        #region ���з���

        /// <summary>
        /// װ����ϵͳ
        /// </summary>
        /// <param name="name">��ϵͳ���ƣ���ӦMEFװ��·����</param>
        /// <returns>��ϵͳȫ�ֶ���</returns>
        public SubSystem Load(Shell shell,string name)
        {
            if (m_SubSystem != null)
            {
                return m_SubSystem;
            }
            Initialize();
            SubSystem subSystem = GetSystemInstance(XSystem.GetSubSystemSpec(name));
            subSystem.shell = shell;
            m_SubSystem = subSystem;
            m_FunctionActions.Clear();
            m_FunctionActions_All.Clear();
            return subSystem;
        }

        /// <summary>
        /// ���¼��ع���
        /// </summary>
        public abstract void ReloadProjects();

        /// <summary>
        /// ��ʼ��
        /// </summary>
        public abstract void Initialize();

        /// <summary>
        /// ��ȡ��Ӧ����ϵͳʵ��
        /// </summary>
        /// <param name="spec">��ϵͳ���</param>
        /// <returns>��ϵͳʵ������</returns>
        public abstract SubSystem GetSystemInstance(IShellSpec spec);

        /// <summary>
        /// ��װ����
        /// </summary>
        public abstract void InstallCommand(bool bReload);

        /// <summary>
        /// ��ϵͳ�����
        /// </summary>
        /// <returns>���ڰ������</returns>
        public abstract IEnumerable<Lazy<Action<SubSystem>, ICommandMetadataView>> GetCommands();

        /// <summary>
        /// ����Key���ToolStrip
        /// </summary>
        /// <param name="key">ToolStrip����</param>
        /// <returns>ToolStrip����</returns>
        public virtual ToolStrip GetToolStrip(string key)
        {
            if (m_Toolbars == null || !m_Toolbars.ContainsKey(key) )
            {
                return null;
            }
      
            return m_Toolbars[key];
        }

        /// <summary>
        /// ����Key���ContextMenu
        /// </summary>
        /// <param name="key">ContextMenu����</param>
        /// <returns>ContextMenu����</returns>
        public virtual ContextMenuStrip GetContextMenu(string key)
        {
            if (m_ContextMenus == null || !m_ContextMenus.ContainsKey(key))
            {
                return null;
            }
            return m_ContextMenus[key];
        }


        /// <summary>
        /// ��ʾĳ�������Ĳ˵�
        /// </summary>
        /// <param name="key">�˵���</param>
        /// <param name="control">�����Ŀؼ�</param>
        /// <param name="position">λ��</param>
        public virtual void ShowContextMenu(string key, Control control, Point position)
        {
            GetContextMenu(key).Show(control, position);
        }

        /// <summary>
        /// ��ȡ����������λ��
        /// </summary>
        /// <param name="strip">������</param>
        /// <returns>����</returns>
        public virtual int GetRowNumber(ToolStrip strip)
        {
            FunctionAction function = GetFunctionActionByName(strip.Name);
            if (function == null)
            {
                return -1;
            }
            return function.FuncStruct.Row;
        }

        #endregion // ���з���

        #region ��������

        /// <summary>
        /// �������ƻ�ȡ������ִ�ж�����
        /// </summary>
        /// <param name="name">����</param>
        /// <returns>����ִ�ж���</returns>
        protected FunctionAction GetFunctionActionByName(string name)
        {
            IEnumerable<FunctionAction> iterator =
                m_FunctionActions_All.Where(c => c.FuncStruct.Name == name);
            if (iterator.Count() < 1)
            {
                return null;
            }
            return iterator.First();
        }

        /// <summary>
        /// �½�һ����ϵͳʵ��
        /// </summary>
        /// <param name="spec">���</param>
        /// <returns>��ϵͳ</returns>
        protected virtual SubSystem NewSystemInstance(IShellSpec spec)
        {
            return null;
        }

        /// <summary>
        /// ˢ��״̬
        /// </summary>
        internal protected virtual void Refresh()
        { 
        }

        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        /// <summary>
        /// ��ϵͳ
        /// </summary>
        protected SubSystem m_SubSystem = null;
                
        /// <summary>
        /// ��ϵͳ����ϣ����ڰ�)
        /// </summary>
        [ImportMany(AllowRecomposition = true)]
        protected Lazy<Action<SubSystem>, ICommandMetadataView>[] Commands = null;

        /// <summary>
        /// ���氲װ������������
        /// </summary>
        protected string m_CategoryName;

        /// <summary>
        /// ��ȡ���˵����
        /// </summary>
        public ReadOnlyDictionary<string, ToolStripItem> MainMenuItems
        {
            get
            {
                return m_items == null ? null :
                    new ReadOnlyDictionary<string, ToolStripItem>(m_items);
            }
        }

        /// <summary>
        /// ���˵����
        /// </summary>
        protected Dictionary<string, ToolStripItem> m_items;

        /// <summary>
        /// ��ȡ����������
        /// </summary>
        public ReadOnlyDictionary<string, ToolStrip> Toolbars
        {
            get
            {
                return m_Toolbars == null ? null :
                    new ReadOnlyDictionary<string, ToolStrip>(m_Toolbars);
            }
        }

        /// <summary>
        /// �������б�
        /// </summary>
        protected Dictionary<string, ToolStrip> m_Toolbars;

        /// <summary>
        /// ��ȡ�˵�����
        /// </summary>
        public ReadOnlyDictionary<string, ContextMenuStrip> Menus
        {
            get
            {
                return m_ContextMenus == null ? null : 
                    new ReadOnlyDictionary<string, ContextMenuStrip>(m_ContextMenus);
            }
        }

        /// <summary>
        /// �Ҽ��˵��б�
        /// </summary>
        protected Dictionary<string, ContextMenuStrip> m_ContextMenus;

        /// <summary>
        /// ��ȡ���ܽṹ����
        /// </summary>
        public ReadOnlyCollection<FunctionAction> FunctionActions
        {
            get
            {
                return m_FunctionActions_All == null ? null :
                    new ReadOnlyCollection<FunctionAction>(m_FunctionActions_All);
            }
        }

        /// <summary>
        /// ���ܽṹ����
        /// </summary>
        protected Collection<FunctionAction> m_FunctionActions_All = new Collection<FunctionAction>();


        /// <summary>
        /// �ȼ���FunctionAction�Ĺ�������
        /// </summary>
        internal protected Dictionary<Keys, FunctionAction> m_keyBuffer = new Dictionary<Keys, FunctionAction>();

        /// <summary>
        /// ���ܵ���Stack
        /// </summary>
        public readonly Stack<FunctionAction> m_FunctionActions = new Stack<FunctionAction>();

        /// <summary>
        /// ��ȡ���ߴ�����
        /// </summary>
        public ReadOnlyDictionary<string, IToolWindow> ToolWindows
        {
            get
            {
                return m_toolWindows == null ? null 
                    : new ReadOnlyDictionary<string, IToolWindow>(m_toolWindows);
            }
        }

        /// <summary>
        /// ���ߴ��б�
        /// </summary>
        protected Dictionary<string, IToolWindow> m_toolWindows;

        #endregion // ���Լ���˽�б���

    }
}