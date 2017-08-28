#region CLR�汾 4.0.30319.239
// IResourceService �ӿ�
// ʱ�䣺2011-11-10 14:04:17
// ���ƣ�IResourceService 
// ��٣���Դ�������ӿ�
//
// �����ˣ�����
// ��Ȩ��2011 ��������ʵ�����¼����ɷ����޹�˾ ��Ȩ����
// ��ע��
// ========================================================
//  ����		�޸���		����
#endregion
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;

namespace TDQS.Contracts
{
    /// <summary>
    /// ��Դ�������ӿ�
    /// </summary>
    public interface IResourceService : IService
    {
        #region ����
        /// <summary>
        /// �����Դ���ṩ��
        /// </summary>
        /// <returns></returns>
        IResourceProvider GetPackgeProvider();

        /// <summary>
        /// �����Դ���ṩ��
        /// </summary>
        /// <param name="aResourceMode">��Դģʽ</param>
        /// <param name="aAssembly">����</param>
        /// <returns></returns>
        IResourceProvider GetPackgeProvider(ResourceMode aResourceMode, Assembly aAssembly);

        /// <summary>
        /// ����ַ�����Դ������
        /// </summary>
        /// <returns></returns>
        IResourceHandler GetStrResourceHandler();

        /// <summary>
        /// ���ͼƬ��Դ������
        /// </summary>
        /// <returns></returns>
        IResourceHandler GetImageResourceHandler();

        /// <summary>
        /// ��ö�����Դ������
        /// </summary>
        /// <returns></returns>
        IResourceHandler GetObjResourceHandler();

        /// <summary>
        /// �����Դ�ַ���,�����ڲ���Դ���ң�����Common����
        /// </summary>
        /// <param name="aName">��Դ����</param>
        /// <returns></returns>
        string GetString(string aName);

        /// <summary>
        /// �����ԴͼƬ,�����ڲ���Դ���ң�����Common����
        /// </summary>
        /// <param name="aName">��Դ����</param>
        /// <returns></returns>
        Image GetImage(string aName);

        /// <summary>
        /// �����Դ����,�����ڲ���Դ���ң�����Common����
        /// </summary>
        /// <param name="aName"></param>
        /// <returns></returns>
        object GetObject(string aName);
        #endregion // ����

        #region ����
        /// <summary>
        /// ��Դ������
        /// </summary>
        IResourceHandler ResourceHandler { get; }

        /// <summary>
        /// ��Դ�ṩ��
        /// </summary>
        IResourceProvider ResourceProvider { get; }
        #endregion // ����

        #region �¼�
        #endregion // �¼�
    }
}

