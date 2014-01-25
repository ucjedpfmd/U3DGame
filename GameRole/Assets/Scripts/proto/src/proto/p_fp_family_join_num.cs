namespace proto {
	public class p_fp_family_join_num : Message
	{
		public double family_id = 0;
		public string family_name = null;
		public int num = 0;
		public p_fp_family_join_num() {
		}
		public override string getClassName() {
			return "p_fp_family_join_num";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"family_id", "double", "null"},new string[] {"family_name", "string", "null"},new string[] {"num", "int", "null"}};
		}
	}
}
