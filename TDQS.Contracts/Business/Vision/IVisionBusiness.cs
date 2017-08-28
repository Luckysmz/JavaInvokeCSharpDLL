#region CLR�汾 4.0.30319.239
// IVisionBusiness �ӿ�
// ʱ�䣺2011/12/8 10:51:51
// ���ƣ���Ұ����ӿ�
// ��٣�
//
// �����ˣ�������
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TDQS.Contracts
{
    /// <summary>
    /// ��Ұ����ӿ�
    /// </summary>
    public interface IVisionBusiness
    {
        #region ����
        /// <summary>
        /// ������Ұģ��
        /// </summary>
        /// <param name="vml"></param>
        void VisionModelAppend(IVisionModel vml);
        /// <summary>
        /// ������Ұģ��
        /// </summary>
        /// <param name="visionname"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        void VisionAppend(string visionname, string x1, string y1, string x2, string y2);
        /// <summary>
        /// �滻��Ұ��Ϣ
        /// </summary>
        /// <param name="visionname"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        void VisionReplace(string visionname, string x1, string y1, string x2, string y2);
        /// <summary>
        /// �������Ƶõ���Ұģ��
        /// </summary>
        /// <param name="name">��Ұ����</param>
        /// <returns></returns>
        IVisionModel GetVisionModelLayerByName(string name);
        /// <summary>
        /// �õ�ָ��λ�õ���Ұģ�Ͷ���
        /// </summary>
        /// <param name="index">���</param>
        /// <returns></returns>
        IVisionModel GetVisionModelAtIndex(int index);

        /// <summary>
        /// ȷ����Ұģ���Ƿ����
        /// </summary>
        /// <param name="vml"></param>
        /// <returns></returns>
        bool VisionModelLayerExist(IVisionModel vml);
        /// <summary>
        /// ȷ��ָ�����Ƶ���Ұ�Ƿ����
        /// </summary>
        /// <param name="name">��Ұ����</param>
        /// <returns>�Ƿ����</returns>
        bool VisionModelLayerExist(string name);
        /// <summary>
        /// ��ָ��λ�ò�����Ұģ��
        /// </summary>
        /// <param name="vml"></param>
        /// <param name="index"></param>
        void VisionModelInsert(IVisionModel vml, int index = 0);
        /// <summary>
        /// ��������ɾ����Ұ
        /// </summary>
        /// <param name="name"></param>
        void VisionModelRemove(string name);
        /// <summary>
        /// �õ����ݼ�
        /// </summary>
        /// <returns></returns>
        DataTable GetDataTable();
        #endregion // ����

        #region ����
        /// <summary>
        /// ��ȡ�Ѵ�����Ұ
        /// </summary>
        int Count
        {
            get;
        }

        /// <summary>
        /// �õ�ģ�ͼ���
        /// </summary>
        /// <returns></returns>
        List<IVisionModel> GetVisionModelList
        {
            get;
        }
        #endregion // ����

        #region �¼�
        /// <summary>
        /// �������¼�
        /// </summary>
        event EventHandler VisionNewItem;
        #endregion // �¼�
    }
}

