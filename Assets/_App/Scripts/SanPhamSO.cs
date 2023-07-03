using Sirenix.OdinInspector;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SanphamSO", order = 1)]
public class SanPhamSO : ScriptableObject
{
    [InlineProperty]public SanPham[] SanPham;

    [Button]
    public void SetID()
    {
        for (int i = 0; i < SanPham.Length; i++)
        {
            SanPham[i].ID = i;
        }
    }

    [Button]
    public void SetID0()
    {
        for (int i = 0; i < SanPham.Length; i++)
        {
            SanPham[i].ID = i;
            SanPham[i].gia = "120.000 đ";
            SanPham[i].name = "Áo Bóng Đá CLB Inter Milan Xanh Kẻ Trắng...";
        }
    }

    public SanPham GetSanPhamWithID(int id)
    {
        return SanPham[id];
    }
}