namespace proto {
	public class m_pet_arena_fight_tos : Message
	{
		public double role_id = 0;
		public string role_name = null;
		public m_pet_arena_fight_tos() {
		}
		public override string getMethodName() {
			return "pet_arena_fight";
		}
		public override string getClassName() {
			return "m_pet_arena_fight_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"role_id", "double", "null"},new string[] {"role_name", "string", "null"}};
		}
	}
}
