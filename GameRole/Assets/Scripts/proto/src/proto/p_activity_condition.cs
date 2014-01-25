namespace proto {
	public class p_activity_condition : Message
	{
		public int condition_id = 0;
		public string condition_str = null;
		public object[] condition_goods;
		public int multi = 0;
		public object[] prize_goods;
		public int able = 0;
		public p_activity_button button = null;
		public p_activity_condition() {
		}
		public override string getClassName() {
			return "p_activity_condition";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"condition_id", "int", "null"},new string[] {"condition_str", "string", "null"},new string[] {"condition_goods", "array", "p_activity_goods"},new string[] {"multi", "int", "null"},new string[] {"prize_goods", "array", "p_activity_goods"},new string[] {"able", "int", "null"},new string[] {"button", "p_activity_button", "null"}};
		}
	}
}
