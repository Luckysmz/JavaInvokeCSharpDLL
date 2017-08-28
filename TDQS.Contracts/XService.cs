#region CLR�汾 4.0.30319.239
// XSystem ��
// ʱ�䣺2011-11-25 9:49:26
// ���ƣ�XSystem
// ��٣�ϵͳ�����������
//
// �����ˣ�����ΰ
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace TDQS.Contracts
{
    /// <summary>
    /// ϵͳ�����������
    /// </summary>
    public partial class XSystem
    {

        #region ���з���
        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        // TODO: Code Analysis Start(������ 2012/10/23 17:56:36)
        // ����: [Υ����չԭ��] 
        // ���س̶�: [ 2  ] ��1:�ǳ�����  2:���� 3:һ�㣩 
        // ��ϸ˵��:  
        //            
        // ======================================================= 
        //  ����		   �޸���	    	���� 

        /// <summary>
        /// �쳣����
        /// </summary>
        public static IExceptionService ExceptionService
        {
            get
            {
                if (m_exceptionService == null)
                {
                    m_exceptionService = ServicesContainer.Instance.GetExceptionService();
                }
                return m_exceptionService;
            }
            set
            {
                m_exceptionService = value;
            }
        }
        private static IExceptionService m_exceptionService = null;
        // TODO: Code Analysis Start(������ 2012/10/23 17:59:47)
        // ����: [Υ����̹淶������Ҫ�����ϸ���] 
        // ���س̶�: [ 2  ] ��1:�ǳ�����  2:���� 3:һ�㣩 
        // ��ϸ˵��:  
        //            
        // ======================================================= 
        //  ����		   �޸���	    	���� 

        /// <summary>
        ///��ȡ��������־����
        /// </summary>
        public static ILogService LogService
        {
            get
            {
                if (m_logService == null)
                {
                    m_logService = ServicesContainer.Instance.GetLogService();
                }
                return m_logService;
            }
            set
            {
                LogService = value;
            }
        }
        /// <summary>
        ///��ȡ��������־����
        /// </summary>
        private static ILogService m_logService = null;
        /// <summary>
        /// Ĭ����־������
        /// </summary>
        public static ILogHandler LogHandler
        {
            get
            {
                if (LogService != null)
                {
                    return LogService.GetLogger("TDQS.CNP");
                }
                return null;
            }
        }
        // Code Analysis End(������ 2012/10/23 18:00:01)

        /// <summary>
        /// ��ȡ��������Դ����
        /// </summary>
        public static IResourceService ResourceService
        {
            get
            {
                if (m_resourceService == null)
                {
                    m_resourceService = ServicesContainer.Instance.GetResourceService();
                }
                return m_resourceService;
            }
            set
            {
                m_resourceService = value;
            }
        }
        /// <summary>
        /// ��ȡ��������Դ����
        /// </summary>
        private static IResourceService m_resourceService = null;
        /// <summary>
        /// ��ȡ�����ö������л�����
        /// </summary>
        public static ISerializeService SerializeService
        {
            get 
            {
                if (m_serializeService == null)
                {
                    m_serializeService = ServicesContainer.Instance.GetSerializeService();
                }
                return m_serializeService; 
            }
            set 
            { 
                m_serializeService = value; 
            }
        }
        /// <summary>
        /// ��ȡ�����ö������л�����
        /// </summary>
        private static ISerializeService m_serializeService = null;

        /// <summary>
        /// ��ȡ���������÷���
        /// </summary>
        public static IConfigService ConfigService
        {
            get
            {
                if (m_configService == null)
                {
                    m_configService = ServicesContainer.Instance.GetConfigService();
                }
                return m_configService;
            }
            set
            {
                m_configService = value;
            }
        }
        /// <summary>
        /// ��ȡ���������÷���
        /// </summary>
        private static IConfigService m_configService = null;

        /// <summary>
        /// ��ȡ��������Ȩ����
        /// </summary>
        public static IAuthorizeService AuthorizeService
        {
            get
            {
                if (m_authorizeService == null)
                {
                    m_authorizeService = ServicesContainer.Instance.GetAuthorizeService();
                }
                return m_authorizeService;
            }
            set
            {
                if (m_authorizeService == value)
                {
                    return;
                }
                m_authorizeService = value;
            }
        }

        /// <summary>
        /// ��ȡ��������Ȩ����
        /// </summary>
        private static IAuthorizeService m_authorizeService;


       

        // Code Analysis End(������ 2012/10/23 17:56:55)
        #endregion // ���Լ���˽�б���

    }
}