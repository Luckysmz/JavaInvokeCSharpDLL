#region CLR�汾 4.0.30319.269
// SubSystem ��
// ʱ�䣺2012-5-16 15:43:17
// ���ƣ�SubSystem ��
// ��٣���ϵͳ�࣬����洢��ϵͳȫ�ֶ���
//
// �����ˣ�����
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;


namespace TDQS.Contracts
{
    /// <summary>
    /// ��ϵͳ�࣬����洢��ϵͳȫ�ֶ���
    /// </summary>
    public abstract class SubSystem
    {
        // TODO: Code Analysis Start(������ 2012/10/24 16:27:36) (����)
        // ����: [���̿��Ż�������ṹ����] 
        // ���س̶�: [ 1  ] ��1:�ǳ�����  2:���� 3:һ�㣩 
        // ��ϸ˵��:  
        // 1����ȷIShellSpec��SubSystem�Ĺ�ϵ��1��1��subsystem��¼ishellspec�ɹ��촫�룬ȥ��subsystem�е�ishellspec���Զ���
        // 2��Subsystem�빤���Ĺ�ϵ���������������õĹ������ȶ�����subsystem��ӷ���
        // 3��Subsystem�ṩ������MainShell���ʲ���
        // ======================================================= 
        //  ����		   �޸���	    	���� 
        
        // Code Analysis End(������ 2012/10/24 16:27:39)
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public SubSystem(SubSystemFactory subSystemFactory, IShellSpec spec)
        {
            m_SubSystemFactory = subSystemFactory;
            m_spec = spec;            
        }

        #endregion // ���������

        #region ���з���
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        /// <summary>
        /// ��ϵͳ����
        /// </summary>
        private string m_Name;

        /// <summary>
        /// ��ϵͳ����
        /// </summary>
        protected SubSystemFactory m_SubSystemFactory = null;

        /// <summary>
        /// ��
        /// </summary>
        private Shell m_Shell = null;

        /// <summary>
        /// ��
        /// </summary>
        public Shell shell
        {
            get
            {
                return m_Shell;
            }
            set
            {
                m_Shell = value;
            }
        }

        /// <summary>
        /// ��ϵͳ����(��д����Ӧ·��)
        /// </summary>
        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }

        /// <summary>
        /// ��ϵͳ����
        /// </summary>
        public SubSystemFactory SubSystemFactory
        {
            get
            {
                return m_SubSystemFactory;
            }
        }

        /// <summary>
        /// ��ȡ��Ӧ����ϵͳ���
        /// </summary>
        public IShellSpec Spec
        {
            get
            {
                return m_spec;
            }
        }

        /// <summary>
        /// �ڲ��Ĵ����ϵͳ���
        /// </summary>
        private IShellSpec m_spec;

        /// <summary>
        /// ����������
        /// </summary>
        public virtual ITriggerManager TriggerManager
        {
            get
            {
                return m_triggerManager;
            }
        }

        /// <summary>
        /// ����������
        /// </summary>
        protected ITriggerManager m_triggerManager;

        #endregion // ���Լ���˽�б���
    }
}