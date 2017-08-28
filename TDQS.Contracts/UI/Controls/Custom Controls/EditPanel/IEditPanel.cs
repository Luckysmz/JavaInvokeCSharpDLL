#region CLR�汾 4.0.30319.239
// IEditPanel �ӿ�
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�IEditPanel 
// ��٣��������ݱ༭��Ӧ�̳���BaseLib��ctlEditPanel�Զ���ؼ�����ʵ�ֱ��ӿ�
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TDQS.Contracts
{
    /// <summary>
    /// �������ݱ༭��Ӧ�̳���BaseLib��ctlEditPanel�Զ���ؼ�����ʵ�ֱ��ӿڡ�
    /// </summary>
    public interface IEditPanel
    {
        #region ����
        /// <summary>
        /// ��ʼ���ؼ�
        /// </summary>
        void mInit();
        /// <summary>
        /// ��������
        /// </summary>
        /// <returns></returns>
        bool mLoad();
        /// <summary>
        /// ��������,ȷ��
        /// </summary>
        /// <returns></returns>
        bool mSave();
        /// <summary>
        /// ȡ�����棬ȡ��
        /// </summary>
        void mCancel();
        /// <summary>
        /// ��֤����
        /// </summary>
        /// <returns></returns>
        bool mValidate();
        /// <summary>
        /// ���ûָ�Ĭ��ֵ
        /// </summary>
        void mDefault();
        #endregion // ����

        #region ����
        /// <summary>
        /// �û��ؼ�ʵ��
        /// </summary>
        UserControl View { get; }

        /// <summary>
        /// �����ⲿ��ʼ����������
        /// </summary>
        object DataObj { get; set; }

        /// <summary>
        /// �Ƿ����
        /// </summary>
        bool IfLoad { get; }

        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

