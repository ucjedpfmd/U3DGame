namespace proto {
	public class m_walk_pet_action_done_toc : Message
	{
		public int action_id = 0;
		public object[] pets;
		public m_walk_pet_action_done_toc() {
		}
		public override string getMethodName() {
			return "walk_pet_action_done";
		}
		public override string getClassName() {
			return "m_walk_pet_action_done_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"action_id", "int", "null"},new string[] {"pets", "array", "p_pet_exp"}};
		}
	}
}
