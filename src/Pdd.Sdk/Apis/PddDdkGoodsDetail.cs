using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Pdd.Sdk.Apis
{
    /// <summary>
    /// 多多进宝商品详情查询--请求参数
    /// 查询多多进宝商品详情
    /// pdd.ddk.goods.detail
    /// https://open.pinduoduo.com/#/apidocument/port?id=pdd.ddk.goods.detail
    /// </summary>
    public class PddDdkGoodsDetailRequest : PddBaseRequest
    {
        protected override string Type => "pdd.ddk.goods.detail";

        public PddDdkGoodsDetailRequest() { }

        public PddDdkGoodsDetailRequest(string clientId, string clientSecret) : base(clientId, clientSecret) { }

        public async Task<PddDdkGoodsDetailResponse> InvokeAsync()
            => await PostAsync<PddDdkGoodsDetailResponse>();
        /// <summary>
        /// 必填
        /// 商品ID，仅支持单个查询。例如：[123456]
        /// </summary>
        public long[] GoodsIdList { get; set; }
        /// <summary>
        /// 不必填
        /// 推广位id
        /// </summary>
        public string Pid { get; set; }
        /// <summary>
        /// 不必填
        /// 自定义参数
        /// </summary>
        public string CustomParameters { get; set; }
        /// <summary>
        /// 不必填
        /// 招商多多客ID
        /// </summary>
        public long? ZsDuoId { get; set; }
        /// <summary>
        /// 不必填
        /// 佣金优惠券对应推广类型，3：专属 4：招商
        /// </summary>
        public int? PlanType { get; set; }
    }


    /// <summary>
    /// 多多进宝商品详情查询--响应参数
    /// 查询多多进宝商品详情
    /// </summary>
    public class PddDdkGoodsDetailResponse : PddBaseResponse
    {
        /// <summary>
        /// response
        /// </summary>
        [JsonProperty("goods_detail_response")]
        public PddDdkGoodsDetail_GoodsDetailResponse GoodsDetailResponse { get; set; }
    }

    /// <summary>
    /// 多多进宝商品对象列表
    /// </summary>
    public class PddDdkGoodsDetail_GoodsDetails
    {
        /// <summary>
        /// 店铺优惠券id
        /// </summary>
        [JsonProperty("mall_coupon_id")]
        public long? MallCouponId { get; set; }
        /// <summary>
        /// 店铺折扣
        /// </summary>
        [JsonProperty("mall_coupon_discount_pct")]
        public int? MallCouponDiscountPct { get; set; }
        /// <summary>
        /// 最小使用金额
        /// </summary>
        [JsonProperty("mall_coupon_min_order_amount")]
        public int? MallCouponMinOrderAmount { get; set; }
        /// <summary>
        /// 最大使用金额
        /// </summary>
        [JsonProperty("mall_coupon_max_discount_amount")]
        public int? MallCouponMaxDiscountAmount { get; set; }
        /// <summary>
        /// 店铺券总量
        /// </summary>
        [JsonProperty("mall_coupon_total_quantity")]
        public long? MallCouponTotalQuantity { get; set; }
        /// <summary>
        /// 店铺券余量
        /// </summary>
        [JsonProperty("mall_coupon_remain_quantity")]
        public long? MallCouponRemainQuantity { get; set; }
        /// <summary>
        /// 店铺券使用开始时间
        /// </summary>
        [JsonProperty("mall_coupon_start_time")]
        public long? MallCouponStartTime { get; set; }
        /// <summary>
        /// 店铺券使用结束时间
        /// </summary>
        [JsonProperty("mall_coupon_end_time")]
        public long? MallCouponEndTime { get; set; }
        /// <summary>
        /// 参与多多进宝的商品ID
        /// </summary>
        [JsonProperty("goods_id")]
        public long? GoodsId { get; set; }
        /// <summary>
        /// 参与多多进宝的商品标题
        /// </summary>
        [JsonProperty("goods_name")]
        public string GoodsName { get; set; }
        /// <summary>
        /// 参与多多进宝的商品描述
        /// </summary>
        [JsonProperty("goods_desc")]
        public string GoodsDesc { get; set; }
        /// <summary>
        /// 多多进宝商品主图
        /// </summary>
        [JsonProperty("goods_image_url")]
        public string GoodsImageUrl { get; set; }
        /// <summary>
        /// 商品轮播图
        /// </summary>
        [JsonProperty("goods_gallery_urls")]
        public string[] GoodsGalleryUrls { get; set; }
        /// <summary>
        /// 已售卖件数
        /// </summary>
        [JsonProperty("sold_quantity")]
        public long? SoldQuantity { get; set; }
        /// <summary>
        /// 最低价sku的拼团价，单位为分
        /// </summary>
        [JsonProperty("min_group_price")]
        public long? MinGroupPrice { get; set; }
        /// <summary>
        /// 最低价sku的单买价，单位为分
        /// </summary>
        [JsonProperty("min_normal_price")]
        public long? MinNormalPrice { get; set; }
        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonProperty("mall_name")]
        public string MallName { get; set; }
        /// <summary>
        /// 商品标签ID，使用pdd.goods.opt.get接口获取
        /// </summary>
        [JsonProperty("opt_id")]
        public long? OptId { get; set; }
        /// <summary>
        /// 商品标签名称
        /// </summary>
        [JsonProperty("opt_name")]
        public string OptName { get; set; }
        /// <summary>
        /// 商品标签ID
        /// </summary>
        [JsonProperty("opt_ids")]
        public int[] OptIds { get; set; }
        /// <summary>
        /// 商品一~四级类目ID列表
        /// </summary>
        [JsonProperty("cat_ids")]
        public int[] CatIds { get; set; }
        /// <summary>
        /// 优惠券门槛金额，单位为分
        /// </summary>
        [JsonProperty("coupon_min_order_amount")]
        public long? CouponMinOrderAmount { get; set; }
        /// <summary>
        /// 优惠券面额，单位为分
        /// </summary>
        [JsonProperty("coupon_discount")]
        public long? CouponDiscount { get; set; }
        /// <summary>
        /// 优惠券总数量
        /// </summary>
        [JsonProperty("coupon_total_quantity")]
        public long? CouponTotalQuantity { get; set; }
        /// <summary>
        /// 优惠券剩余数量
        /// </summary>
        [JsonProperty("coupon_remain_quantity")]
        public long? CouponRemainQuantity { get; set; }
        /// <summary>
        /// 优惠券生效时间，UNIX时间戳
        /// </summary>
        [JsonProperty("coupon_start_time")]
        public long? CouponStartTime { get; set; }
        /// <summary>
        /// 优惠券失效时间，UNIX时间戳
        /// </summary>
        [JsonProperty("coupon_end_time")]
        public long? CouponEndTime { get; set; }
        /// <summary>
        /// 佣金比例，千分比
        /// </summary>
        [JsonProperty("promotion_rate")]
        public long? PromotionRate { get; set; }
        /// <summary>
        /// 商品评价分
        /// </summary>
        [JsonProperty("goods_eval_score")]
        public double? GoodsEvalScore { get; set; }
        /// <summary>
        /// 商品评价数
        /// </summary>
        [JsonProperty("goods_eval_count")]
        public long? GoodsEvalCount { get; set; }
        /// <summary>
        /// 商品类目ID，使用pdd.goods.cats.get接口获取
        /// </summary>
        [JsonProperty("cat_id")]
        public long? CatId { get; set; }
        /// <summary>
        /// 描述评分
        /// </summary>
        [JsonProperty("avg_desc")]
        public long? AvgDesc { get; set; }
        /// <summary>
        /// 物流评分
        /// </summary>
        [JsonProperty("avg_lgst")]
        public long? AvgLgst { get; set; }
        /// <summary>
        /// 服务评分
        /// </summary>
        [JsonProperty("avg_serv")]
        public long? AvgServ { get; set; }
        /// <summary>
        /// 描述评分击败同类店铺百分比
        /// </summary>
        [JsonProperty("desc_pct")]
        public double? DescPct { get; set; }
        /// <summary>
        /// 物流评分击败同类店铺百分比
        /// </summary>
        [JsonProperty("lgst_pct")]
        public double? LgstPct { get; set; }
        /// <summary>
        /// 服务评分击败同类店铺百分比
        /// </summary>
        [JsonProperty("serv_pct")]
        public double? ServPct { get; set; }
        /// <summary>
        /// 模糊销量
        /// </summary>
        [JsonProperty("sales_tip")]
        public string SalesTip { get; set; }
        /// <summary>
        /// 商家id
        /// </summary>
        [JsonProperty("mall_id")]
        public long? MallId { get; set; }
    }
    /// <summary>
    /// response
    /// </summary>
    public class PddDdkGoodsDetail_GoodsDetailResponse
    {
        /// <summary>
        /// 多多进宝商品对象列表
        /// </summary>
        [JsonProperty("goods_details")]
        public PddDdkGoodsDetail_GoodsDetails[] GoodsDetails { get; set; }
    }
}

