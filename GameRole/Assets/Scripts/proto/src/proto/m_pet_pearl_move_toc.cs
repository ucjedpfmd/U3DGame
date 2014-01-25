namespace proto {
	public class m_pet_pearl_move_toc : Message
	{
		public int err_code = 0;
		public object[] update_changes;
		public object[] delete_changes;
		public m_pet_pearl_move_toc() {
		}
		public override string getMethodName() {
			return "pet_pearl_move";
		}
		public override string getClassName() {
			return "m_pet_pearl_move_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"update_changes", "array", "p_pet_pearl"},new string[] {"delete_changes", "array", "p_pet_pearl"}};
		}
	}
}
