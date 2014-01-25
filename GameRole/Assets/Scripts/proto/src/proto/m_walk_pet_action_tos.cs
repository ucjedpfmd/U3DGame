namespace proto {
	public class m_walk_pet_action_tos : Message
	{
		public int action_id = 0;
		public double target_id = 0;
		public double target_pet_id = 0;
		public int formation = 0;
		public m_walk_pet_action_tos() {
		}
		public override string getMethodName() {
			return "walk_pet_action";
		}
		public override string getClassName() {
			return "m_walk_pet_action_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"action_id", "int", "null"},new string[] {"target_id", "double", "null"},new string[] {"target_pet_id", "double", "null"},new string[] {"formation", "int", "null"}};
		}
	}
}
