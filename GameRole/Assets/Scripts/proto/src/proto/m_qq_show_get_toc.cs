namespace proto {
	public class m_qq_show_get_toc : Message
	{
		public int err_code = 0;
		public p_qq_show self = null;
		public p_qq_show other = null;
		public object[] all_goods;
		public p_show_rank battle_rank = null;
		public p_show_rank sawlu_battle_rank = null;
		public m_qq_show_get_toc() {
		}
		public override string getMethodName() {
			return "qq_show_get";
		}
		public override string getClassName() {
			return "m_qq_show_get_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"self", "p_qq_show", "null"},new string[] {"other", "p_qq_show", "null"},new string[] {"all_goods", "array", "p_shop_goods_info"},new string[] {"battle_rank", "p_show_rank", "null"},new string[] {"sawlu_battle_rank", "p_show_rank", "null"}};
		}
	}
}
