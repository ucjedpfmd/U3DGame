namespace proto {
	public class p_rank_row : Message
	{
		public int row_id = 0;
		public double role_id = 0;
		public object[] elements;
		public object[] int_list;
		public int vip_level = 0;
		public int pfvip_level = 0;
		public int sex = 0;
		public p_rank_row() {
		}
		public override string getClassName() {
			return "p_rank_row";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"row_id", "int", "null"},new string[] {"role_id", "double", "null"},new string[] {"elements", "array", "string"},new string[] {"int_list", "array", "double"},new string[] {"vip_level", "int", "null"},new string[] {"pfvip_level", "int", "null"},new string[] {"sex", "int", "null"}};
		}
	}
}
