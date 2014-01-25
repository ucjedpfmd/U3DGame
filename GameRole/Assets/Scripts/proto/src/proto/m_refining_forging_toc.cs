namespace proto {
	public class m_refining_forging_toc : Message
	{
		public int err_code = 0;
		public int formula_id = 0;
		public int silver_fee = 0;
		public int gold_fee = 0;
		public object[] item_list;
		public m_refining_forging_toc() {
		}
		public override string getMethodName() {
			return "refining_forging";
		}
		public override string getClassName() {
			return "m_refining_forging_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"formula_id", "int", "null"},new string[] {"silver_fee", "int", "null"},new string[] {"gold_fee", "int", "null"},new string[] {"item_list", "array", "p_refining"}};
		}
	}
}
