namespace proto {
	public class m_refining_forging_tos : Message
	{
		public int formula_id = 0;
		public int formula_num = 1;
		public object[] type_id_list;
		public bool bind_first = false;
		public m_refining_forging_tos() {
		}
		public override string getMethodName() {
			return "refining_forging";
		}
		public override string getClassName() {
			return "m_refining_forging_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"formula_id", "int", "null"},new string[] {"formula_num", "int", "null"},new string[] {"type_id_list", "array", "int"},new string[] {"bind_first", "bool", "null"}};
		}
	}
}
