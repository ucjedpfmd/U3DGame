namespace proto {
	public class m_pet_soul_hunt_tos : Message
	{
		public int hunt_times = 0;
		public int npc_id = 0;
		public m_pet_soul_hunt_tos() {
		}
		public override string getMethodName() {
			return "pet_soul_hunt";
		}
		public override string getClassName() {
			return "m_pet_soul_hunt_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"hunt_times", "int", "null"},new string[] {"npc_id", "int", "null"}};
		}
	}
}
