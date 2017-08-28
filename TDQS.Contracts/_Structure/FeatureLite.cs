#region CLR�汾 4.0.30319.296
// FeatureLite ��
// ʱ�䣺2012-2-2 16:58:33
// ���ƣ�ͼԪ��Ϣ�ṹ
// ��٣�ͼԪ������Ϣ
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
using System.Linq;
using System.Text;

namespace TDQS.Contracts
{
    /// <summary>
    /// ͼԪ������Ϣ
    /// </summary>
    public struct FeatureLite
    {
        #region ���������

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="fid">ͼԪid</param>
        public FeatureLite(int fid = -1)
        {
            FID = fid;
            EID = "";
            LayerName = "";
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
        /// ���ڲ�����
        /// </summary>
        /// <param name="value1">ͼԪ������Ϣ</param>
        /// <param name="value2">ͼԪ������Ϣ</param>
        /// <returns>�Ƿ����</returns>
        public static bool operator ==(FeatureLite value1, FeatureLite value2)
        {
            return value1.LayerName == value2.LayerName
                && value1.FID == value2.FID && value1.EID == value2.EID;
        }

        /// <summary>
        /// �����ڲ�����
        /// </summary>
        /// <param name="value1">ͼԪ������Ϣ</param>
        /// <param name="value2">ͼԪ������Ϣ</param>
        /// <returns>�Ƿ񲻵�</returns>
        public static bool operator !=(FeatureLite value1, FeatureLite value2)
        {
            return !(value1 == value2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            return this.GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return (LayerName + FID + (string.IsNullOrEmpty(EID) ? string.Empty : EID)).GetHashCode();
        }

        /// <summary>
        /// ����
        /// </summary>
        public string LayerName;
        /// <summary>
        /// ͼԪID
        /// </summary>
        public int FID;

        /// <summary>
        /// ͼԪ��ӦԪ��ID
        /// </summary>
        public string EID;

        /// <summary>
        /// ����Ϣ
        /// </summary>
        /// <returns></returns>
        public static FeatureLite NullValue
        {
            get
            {
                nullValue.FID = -1;
                return nullValue;
            }
        }
        private static FeatureLite nullValue;
        #endregion // ���Լ���˽�б���

    }
}