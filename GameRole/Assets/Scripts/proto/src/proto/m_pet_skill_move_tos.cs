namespace proto {
	public class m_pet_skill_move_tos : Message
	{
		public int op_type = 0;
		public object[] move_actions;
		public double pet_id = 0;
		public m_pet_skill_move_tos() {
		}
		public override string getMethodName() {
			return "pet_skill_move";
		}
		public override string getClassName() {
			return "m_pet_skill_move_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"move_actions", "array", "p_pet_skill_action"},new string[] {"pet_id", "double", "null"}};
		}
	}
}
