#region CLR�汾 4.0.30319.239
// XSystem ��
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�ϵͳ���ͳһ���ʽӿ�
// ��٣��ṩ��÷������
//
// �����ˣ�����ΰ
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		   �޸���		����
// 2012-11-23  ����         Authenticate��ӣ�
//                          1.ͳһϵͳ����ʱ����Ч����֤�ӿڣ��ϲ����ؼ�����棻
//                          2.��������Ч���⣬ͬʱ���ش�����ʾ���ݣ�
//                          �Ż�Ҫ�������ϡ�
// 2012-11-23  ����         Invoke��ӣ�
//                          1.������ϵͳ�ȼ�ִ�к���������Ϊ��ϵͳ���ȼ���ֵ��
//                          2.ͨ��GetHotkeyMode���������غ���ʵ���ȼ�ƥ����϶���
//                          3.ִ���ȼ���Ӧ��FunctionAction�еķ�����
//                          �Ż�Ҫ�������ϡ�
// 2012-11-23  ����         GetHotkeyMode��ӣ�
//                          1.���ػ�ȡ��ǰ�ȼ�ģʽ�ķ�����
//                          2.���ؽ����ȼ��ַ����ķ�����
//                          �Ż�Ҫ�������ϡ�
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Windows.Forms;
using TDQS.IO;
using TDQS.Win32;

namespace TDQS.Contracts
{
    /// <summary>
    /// �ṩ��÷������
    /// </summary>
    public partial class XSystem
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public XSystem()
        {

        }

        #endregion // ���������

        #region ���з���

        /// <summary>
        /// ͨ��֧�ָ�ʽ����չ����ȡ���
        /// </summary>
        /// <param name="supportedFormat"></param>
        /// <returns></returns>
        public static IShellSpec GetSpec(string supportedFormat)
        {
            if (m_specDictionary == null)
            {
                return null;
            }
            foreach (IShellSpec spec in m_specDictionary.Values)
            {
                if (spec.FileExtension.Equals(supportedFormat, StringComparison.CurrentCultureIgnoreCase))
                {
                    return spec;
                }
                foreach (string format in spec.SupportedFormats)
                {
                    if (!format.Equals(supportedFormat, StringComparison.CurrentCultureIgnoreCase))
                    {
                        continue;
                    }
                    return spec;
                }
            }
            return null;
        }

        /// <summary>
        /// ����ϵͳǰ����Ч����֤
        /// </summary>
        /// <returns>�Ƿ��������</returns>
        public static bool Authenticate(ref string errorMessage)
        {
            //��������Ϊ����Ч��
            if (XSystem.AuthorizeService == null)
            {
                return true;
            }
            //�ⲿ��Ϊ�ճ���������򵥻����ṩ��������ʽ�������Ƴ�
            if (ConfigurationManager.AppSettings["Online"] != "1")
            {
                return true;
            }
            //�ж������Ƿ���ͨ
            if (!IsNetConnect())
            {
                errorMessage = "δ���ӵ���������������������Դ˲�����";
                return false;
            }
            //���Ϊ����棬��Ҫ�Ե�¼�Ƿ�ɹ�Ϊ��֤��׼
            return XSystem.AuthorizeService.Login();
        }

        /// <summary>
        /// ��ϵͳ����ݼ�����ִ��
        /// </summary>
        /// <param name="system">��ϵͳ</param>
        /// <param name="key">��ݼ�</param>
        /// <returns>�Ƿ�ִ��</returns>
        public static bool Invoke(SubSystem system, Keys key)
        {
            //��ϵͳΪ���϶�Ϊδִ��
            if (system == null)
            {
                return false;
            }
            //�ҵ���Ӧ��ݼ��Ķ�����ִ��
            foreach (FunctionAction action in system.SubSystemFactory.FunctionActions)
            {
                //������������������
                if (!action.FuncStruct.GlobalShortcut
                    || string.IsNullOrWhiteSpace(action.FuncStruct.ShortcutKey)
                    || !action.FuncStruct.ShortcutKey.EndsWith(key.ToString()))
                {
                    continue;
                }
                //��ȡ�������ȼ�ģʽ
                HotkeyMode mode = GetHotkeyMode(action.FuncStruct.ShortcutKey);
                //�����ǰ�ȼ�ģʽ�����϶����ȼ�ģʽ������
                if (!mode.In(GetHotkeyMode()))
                {
                    continue;
                }
                //��ȫ����Ҫ����ִ��
                //Ĭ��������Ϣ
                Singleton<ITagged<bool>>.GetInstance().Tag = true;
                action.FuncStruct.Action(system);
                return Singleton<ITagged<bool>>.GetInstance().Tag;
            }
            //δ�ҵ��϶�Ϊδִ��
            return false;
        }

        /// <summary>
        /// ����Ŀ¼�õ����ص�����
        /// </summary>
        /// <param name="directory"></param>
        /// <returns></returns>
        public static CompositionContainer GetContainerByDirectory(string directory)
        {
            if (m_compositionContainers.ContainsKey(directory.ToLower()))
            {
                return m_compositionContainers[directory.ToLower()];
            }
            AggregateCatalog aggregateCatalog = new AggregateCatalog();

            DirectoryCatalog directoryCatalog = new DirectoryCatalog(directory);
            aggregateCatalog.Catalogs.Add(directoryCatalog);

            AssemblyCatalog assemblyCatalog = new AssemblyCatalog(Assembly.GetEntryAssembly());
            aggregateCatalog.Catalogs.Add(assemblyCatalog);

            CompositionContainer container = new CompositionContainer(aggregateCatalog);
            m_compositionContainers.Add(directory.ToLower(), container);
            return m_compositionContainers[directory.ToLower()];
        }
        /// <summary>
        /// ���ݽӿڴ���ϵͳ�õ�ʵ��
        /// </summary>
        /// <typeparam name="T">ʵ���ӿ�</typeparam>
        /// <typeparam name="S">�����ӿ�</typeparam>
        /// <returns></returns>
        public static IEnumerable<T> GetImplementBySystem<T, S>()
        {
            foreach (Lazy<T, S> lazy
               in SubSystemCompositionContainer.GetExports<T, S>())
            {
                yield return lazy.Value;
            }
        }

        /// <summary>
        /// ��ȡ������
        /// </summary>
        /// <typeparam name="TConfig"></typeparam>
        /// <param name="Config"></param>
        /// <returns></returns>
        public static TConfig GetConfig<TConfig>() where TConfig : IConfigContext
        {
            if (ConfigContexts.Find(temp => temp is TConfig) != null)
            {
                return (TConfig)ConfigContexts.Find(temp => temp is TConfig);
            }
            else
            {
                return default(TConfig);
            }
        }

        /// <summary>
        /// ���������
        /// </summary>
        /// <typeparam name="TConfig"></typeparam>
        /// <param name="Config"></param>
        public static void SetConfig<TConfig>(TConfig Config) where TConfig : IConfigContext
        {
            if (Config is IConfigContext)
            {
                IConfigContext c = Config as IConfigContext;
                if (!ConfigContexts.Exists(temp => temp.Equals(c)))
                {
                    ConfigContexts.Add((IConfigContext)Config);
                }
                else
                {

                    IConfigContext c1 = (IConfigContext)ConfigContexts.Find(temp => temp is TConfig);
                    c1 = c;
                }
            }
        }

        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���

        /// <summary>
        /// �ж������Ƿ���ͨ�� true:��ͨ�� false:δ��ͨ
        /// </summary>
        /// <returns></returns>
        private static bool IsNetConnect()
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["postgres"].ToString();

                string[] arrConn = connString.Split(';');

                string ipConn = string.Empty;

                int portConn = 0;

                foreach (string connItem in arrConn)
                {
                    if (connItem.Split('=')[0].ToLower() == "server")
                    {
                        ipConn = connItem.Split('=')[1];
                    }

                    if (connItem.Split('=')[0].ToLower() == "port")
                    {
                        portConn = Convert.ToInt32(connItem.Split('=')[1]);
                    }
                }

                TcpClient tc = new TcpClient(ipConn, portConn);

                if (tc.Connected)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                XSystem.LogHandler.Error(ex.Message);
                Debug.Assert(false, ex.Message + ex.StackTrace);
                return false;
            }
        }

        /// <summary>
        /// ��ȡ�����ȼ�ģʽ
        /// </summary>
        /// <returns>�ȼ�ģʽ</returns>
        private static HotkeyMode GetHotkeyMode()
        {
            HotkeyMode ctrlMode = IsLControlPressed() || IsRControlPressed()
           ? HotkeyMode.Control : HotkeyMode.None;
            HotkeyMode shiftMode = IsLShiftPressed() || IsRShiftPressed()
                ? HotkeyMode.Shift : HotkeyMode.None;
            HotkeyMode altMode = IsRAltPressed() || IsLAltPressed()
                ? HotkeyMode.Alt : HotkeyMode.None;
            return ctrlMode | shiftMode | altMode;
        }

        /// <summary>
        /// �ж���Ctrl�Ƿ���
        /// </summary>
        /// <returns>�Ƿ���</returns>
        private static bool IsLControlPressed()
        {
            return (NativeMethods.GetKeyState((int)VirtualKeyStates.VK_LCONTROL) & 0x80).ToBoolean();
        }
        /// <summary>
        /// �ж���Ctrl�Ƿ���
        /// </summary>
        /// <returns>�Ƿ���</returns>
        private static bool IsRControlPressed()
        {
            return (NativeMethods.GetKeyState((int)VirtualKeyStates.VK_RCONTROL) & 0x80).ToBoolean();
        }
        /// <summary>
        /// �ж���Shift�Ƿ���
        /// </summary>
        /// <returns>�Ƿ���</returns>
        private static bool IsLShiftPressed()
        {
            return (NativeMethods.GetKeyState((int)VirtualKeyStates.VK_LSHIFT) & 0x80).ToBoolean();
        }
        /// <summary>
        /// �ж���Shift�Ƿ���
        /// </summary>
        /// <returns>�Ƿ���</returns>
        private static bool IsRShiftPressed()
        {
            return (NativeMethods.GetKeyState((int)VirtualKeyStates.VK_RSHIFT) & 0x80).ToBoolean();
        }
        /// <summary>
        /// �ж���Alt�Ƿ���
        /// </summary>
        /// <returns>�Ƿ���</returns>
        private static bool IsLAltPressed()
        {
            return (NativeMethods.GetKeyState((int)VirtualKeyStates.VK_LMENU) & 0x80).ToBoolean();
        }
        /// <summary>
        /// �ж���Alt�Ƿ���
        /// </summary>
        /// <returns>�Ƿ���</returns>
        private static bool IsRAltPressed()
        {
            return (NativeMethods.GetKeyState((int)VirtualKeyStates.VK_RMENU) & 0x80).ToBoolean();
        }


        /// <summary>
        /// ��ȡ�ȼ��ַ������ȼ�ģʽ
        /// </summary>
        /// <param name="shortcutKey">�ȼ��ַ���</param>
        /// <returns>�ȼ�ģʽ</returns>
        private static HotkeyMode GetHotkeyMode(string shortcutKey)
        {
            HotkeyMode ctrlMode = shortcutKey.Contains("Control")
                ? HotkeyMode.Control : HotkeyMode.None;
            HotkeyMode shiftMode = shortcutKey.Contains("Shift")
                ? HotkeyMode.Shift : HotkeyMode.None;
            HotkeyMode altMode = shortcutKey.Contains("Alt")
                ? HotkeyMode.Alt : HotkeyMode.None;
            return ctrlMode | shiftMode | altMode;
        }

        #endregion // ˽�з���

        #region ���Լ���˽�б���

        /// <summary>
        /// ��ϵͳMEF��չ��dll
        /// </summary>
        private static string[] LoadSubSystemDll = new string[] { ".dll", ".BusinessLayer.dll" };

        /// <summary>
        /// ��ǰ��ϵͳ����
        /// </summary>
        public static CompositionContainer SubSystemCompositionContainer
        {
            get
            {
                return m_subSystemCompositionContainer;
            }
            set
            {
                m_subSystemCompositionContainer = value;
            }
        }
        private static CompositionContainer m_subSystemCompositionContainer = null;

        /// <summary>
        /// ��ϵͳ�������ձ�
        /// </summary>
        private static Dictionary<string, CompositionContainer> m_compositionContainers
            = new Dictionary<string, CompositionContainer>();

        /// <summary>
        /// ����ϵͳ���
        /// </summary>
        public static Dictionary<string, IShellSpec> SpecDictionary
        {
            get
            {
                return m_specDictionary;
            }
            set
            {
                m_specDictionary = value;
            }
        }

        /// <summary>
        /// ����ϵͳ���
        /// </summary>
        private static Dictionary<string, IShellSpec> m_specDictionary = null;

        /// <summary>
        /// ������չ���ҵ���Ӧ��ϵͳ���
        /// </summary>
        /// <param name="Extension"></param>
        /// <returns></returns>
        public static IShellSpec GetSubSystemSpec(string Extension)
        {
            IShellSpec spec = null;
            if (SpecDictionary.ContainsKey(Extension))
            {
                spec = SpecDictionary[Extension];
            }
            return spec;
        }

        /// <summary>
        /// ������
        /// </summary>
        private static Shell m_shell = null;
        /// <summary>
        /// ������
        /// </summary>
        public static Shell Shell
        {
            get { return m_shell; }
            set { m_shell = value; }
        }

        /// <summary>
        /// ��¼ϵͳ�û���
        /// </summary>
        public static string UserName
        {
            get { return m_UserName; }
            set { m_UserName = value; }
        }
        private static string m_UserName;

        /// <summary>
        /// ����ID
        /// </summary>
        public static string Category
        {
            get
            {
                if (XSystem.Shell != null && XSystem.Shell.ProjectManager.GetActiveProject() != null)
                {
                    m_Category = XSystem.Shell.ProjectManager.GetActiveProject().ID;
                }
                else
                {
                    m_Category = "�չ���";
                }
                return m_Category;
            }
            set { m_Category = value; }
        }
        private static string m_Category;
        /// <summary>
        /// �ͻ���IP��ַ
        /// </summary>
        public static string IP
        {
            get
            {
                if (m_ip == null)
                {
                    foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
                    {
                        if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                        {
                            m_ip = _IPAddress.ToString();
                            return m_ip;
                        }
                    }
                }
                return m_ip;
            }
        }
        internal static string m_ip = null;

        /// <summary>
        /// ��ȡϵͳ����
        /// </summary>
        public static string Name
        {
            get
            {
                return m_chsName + m_type;
            }
        }

        /// <summary>
        /// ��ȡϵͳ��������
        /// </summary>
        public static string ChsName
        {
            get
            {
                return m_chsName;
            }
        }
        private static string m_chsName = "�����滮�������������ϵͳ";

        /// <summary>
        /// ��ȡϵͳ�ͺ�
        /// </summary>
        public static string Type
        {
            get
            {
                return m_type;
            }
        }
        private static string m_type = "TCNP5000";

        /// <summary>
        /// ��ȡ������ϵͳ������״̬
        /// </summary>
        public static bool Online
        {
            get
            {
                return m_online;
            }
            set
            {
                if (m_online == value)
                {
                    return;
                }
                m_online = value;
            }
        }
        private static bool m_online = false;

        /// <summary>
        /// ϵͳ����
        /// </summary>
        public static ISystemConfig SystemConfig
        {
            get
            {
                return m_SystemConfig;
            }
            set
            {
                m_SystemConfig = value;
            }
        }
        private static ISystemConfig m_SystemConfig;

        /// <summary>
        /// ϵͳ�������б�
        /// </summary>
        private static List<IConfigContext> ConfigContexts = new List<IConfigContext>();

        /// <summary>
        /// ������ͱ����ʵ�����ֵ�
        /// </summary>
        public static Dictionary<string, ITreeGridWatch> DicTreeGridFrm = new Dictionary<string, ITreeGridWatch>();

        /// <summary>
        /// ��Ȩ��Ϣ
        /// </summary>
        const string Copyright = "CCECBDF2CCECB4F3C7F3CAB5B5E7C1A6D0C2BCBCCAF5B9C9B7DDD3D0CFDEB9ABCBBE20B0E6C8A8CBF9D3D0";

        /// <summary>
        /// �Ƿ�����ͼ�β���
        /// ���ڽ��ͼ�β�̫��֧�ֶ��̵߳����⣻
        /// �������֣̣���ͣ��ͣ�������ԣ����ͻ
        /// ����ƽ��ӣ�������Ӧ��ʹ�ãϣǣ���д��ȡԪ����ȡ������������������Զ�����
        /// /// </summary>
        public static bool IsLockedGisTool = false;

        
        #endregion // ���Լ���˽�б���

    }
}