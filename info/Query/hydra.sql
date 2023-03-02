/****** Script for SelectTopNRows command from SSMS  ******/

--View a Thi làm để lấy hết thông tin item theo máy hyra
--cột a_status: V-preapared;  E-Finish; L-Running
SELECT *
FROM [mip1].[mipadm].[v_HydraOrders_v2]

--danh sách các máy
select * from [mip1].[mipadm].maschinen

--trạng thái máy đang chạy
  select * from [mip1].[mipadm].maschinen_status
  where m_status = 1


  --các trạng thái máy
  select * from [mip1].[mipadm].[stoertexte]
  --where stoertxt_nr = 801