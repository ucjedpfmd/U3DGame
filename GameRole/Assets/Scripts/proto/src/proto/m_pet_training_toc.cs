namespace proto {
	public class m_pet_training_toc : Message
	{
		public int err_code = 0;
		public int op_type = 0;
		public p_pet pet_info = null;
		public int gold = 0;
		public int silver = 0;
		public int pet_exp = 0;
		public object[] training_bag;
		public m_pet_training_toc() {
		}
		public override string getMethodName() {
			return "pet_training";
		}
		public override string getClassName() {
			return "m_pet_training_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"op_type", "int", "null"},new string[] {"pet_info", "p_pet", "null"},new string[] {"gold", "int", "null"},new string[] {"silver", "int", "null"},new string[] {"pet_exp", "int", "null"},new string[] {"training_bag", "array", "p_pet_brief"}};
		}
	}
}
