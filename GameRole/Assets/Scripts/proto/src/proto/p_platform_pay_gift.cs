namespace proto {
	public class p_platform_pay_gift : Message
	{
		public int id = 0;
		public int normal_status = 0;
		public int vip_status = 0;
		public int gift_id_normal = 0;
		public int gift_id_vip = 0;
		public int need_gold = 0;
		public p_platform_pay_gift() {
		}
		public override string getClassName() {
			return "p_platform_pay_gift";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"id", "int", "null"},new string[] {"normal_status", "int", "null"},new string[] {"vip_status", "int", "null"},new string[] {"gift_id_normal", "int", "null"},new string[] {"gift_id_vip", "int", "null"},new string[] {"need_gold", "int", "null"}};
		}
	}
}
