#region CLR�汾 4.0.30319.239
// IElmentConfig �ӿ�
// ʱ�䣺2012-2-16 16:24:26
// ���ƣ�
// ��٣�
//
// �����ˣ�����
// ��Ȩ��Copyright (C) 2012 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDQS.Contracts
{
    /// <summary>
    /// Ԫ�����ýӿ�,��ǰ����XML���л���ʽ��ȡ
    /// </summary>
    public interface IElementConfig
    {
        #region ����
        /// <summary>
        /// װ������
        /// </summary>
        /// <returns></returns>
        IElementConfig Load();
        /// <summary>
        /// װ������(�������ͼ���)
        /// </summary>
        /// <param name="types">���ͼ���</param>
        /// <returns></returns>
        IElementConfig Load(Type[] types);
        /// <summary>
        /// ��������
        /// </summary>
        void Save();
        /// <summary>
        /// ��������(�������ͼ���)
        /// </summary>
        /// <param name="types">���ͼ���</param>
        void Save(Type[] types);
        /// <summary>
        /// ��ʼ��һ��Ԫ������ͨ��ģ����װ�ز�����Ԫ������.
        /// </summary>
        /// <param name="eleObj">��װ�ص�Ԫ������</param>
        /// <param name="tempObjID">ģ��Ԫ������IDֵ</param>
        /// <param name="bSetup">�Ƿ�ͨ�����ý���װ��</param>
        /// <returns>װ�غõ�ԭ������</returns>
        IElement InitElement(IElement eleObj, string tempObjID, bool bSetup);
        #endregion // ����

        #region ����
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

