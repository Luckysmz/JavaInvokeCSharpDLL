#region CLR�汾 4.0.30319.239
// IToolBox �ӿ�
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�IToolBox �ӿ�
// ��٣�ToolBox��ToolWindow
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TDQS.Contracts
{
    /// <summary>
    /// ToolBox��ToolWindow
    /// </summary>
    public interface IHistroyDocmentWindow : IToolWindow
    {
        #region ����

   

        /// <summary>
        /// ��ʾ��ʷ�����ĵ�
        /// </summary>
        /// <param name="document">�����ļ�</param>
        void Show(IDocument document);

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="document">�����ļ�</param>
        void Validate(IDocument document);


        /// <summary>
        /// ж��
        /// </summary>
        void UnLoad();

        /// <summary>
        /// ����װ��ѡ���еĲ�������
        /// </summary>
        void LoadParamter();

        #endregion // ����

        #region ����
        /// <summary>
        /// ����ʱ��
        /// </summary>
         int BackUpTime
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ����ñ���
        /// </summary>
         bool EnableBackUp
        {
            get;
            set;
        }

        /// <summary>
        /// �����Ƿ�У��
        /// </summary>
         bool EnableValidate
        {
            get;
            set;
        }

        /// <summary>
        /// �Ƿ��������ݻ���
        /// </summary>
         bool IsLock { get; set; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

