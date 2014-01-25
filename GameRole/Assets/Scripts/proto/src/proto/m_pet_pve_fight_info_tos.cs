namespace proto {
	public class m_pet_pve_fight_info_tos : Message
	{
		public double fight_id = 0;
		public m_pet_pve_fight_info_tos() {
		}
		public override string getMethodName() {
			return "pet_pve_fight_info";
		}
		public override string getClassName() {
			return "m_pet_pve_fight_info_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"fight_id", "double", "null"}};
		}
	}
}
