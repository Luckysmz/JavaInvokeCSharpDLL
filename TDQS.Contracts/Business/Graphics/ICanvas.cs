#region CLR�汾 4.0.30319.239
// ICanvas �ӿ�
// ʱ�䣺2011-11-8 16:28:43
// ���ƣ�ICanvas 
// ��٣����л��ƻ����ӿڡ�
//
// ������: ����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;


namespace TDQS.Contracts
{
    /// <summary>
    /// ���л��ƻ����ӿڣ��ṩ����ͼ�ι���
    /// </summary>
    public interface ICanvas
    {
        #region ����

        ///// <summary>
        ///// ���Ʒ�����
        ///// </summary>
        //void Draw();

        ///// <summary>
        ///// ��ʼ��
        ///// </summary>
        ///// <param name="owner">�����ؼ�</param>
        //void Initialize(System.Windows.Forms.Control owner);

        ///// <summary>
        ///// �����л�װ��
        ///// </summary>
        ///// <param name="reader">XML��ȡ��</param>
        //bool LoadFromXml(XmlTextReader reader);

        ///// <summary>
        ///// ���浽���л�
        ///// </summary>
        ///// <param name="sw">��д����</param>
        //bool SaveToXml(StreamWriter sw);

        ///// <summary>
        ///// ���ݱ��޸�
        ///// </summary>
        //void SetDirty();

        #endregion // ����

        #region ����
        /// <summary>
        /// ����ʵ��
        /// </summary>
        Control Instance { get; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

