#region CLR�汾 4.0.30319.239
// IResourceHandler �ӿ�
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�IResourceHandler 
// ��٣���Դ�����ӿ�
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Resources;
using System.Globalization;
using System.Drawing;

namespace TDQS.Contracts
{
    /// <summary>
    /// ��Դ�����ӿ�
    /// </summary>
    public interface IResourceHandler
    {
        #region ����
        /// <summary>
        /// ��ʼ��
        /// </summary>
        /// <param name="aResProvider"></param>
        void Init(IResourceProvider aResProvider);

        /// <summary>
        /// ����ַ�����Դ
        /// </summary>
        /// <param name="aName">��Դ����</param>
        /// <returns>��Դ����</returns>
        string GetString(string aName);

        /// <summary>
        /// ���ͼƬ��Դ
        /// </summary>
        /// <param name="aName">��Դ����</param>
        /// <returns>��Դ����</returns>
        Image GetImage(string aName);

        /// <summary>
        /// ��ö�����Դ
        /// </summary>
        /// <param name="aName">��Դ����</param>
        /// <returns>��Դ����</returns>
        object GetObject(string aName);
        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

