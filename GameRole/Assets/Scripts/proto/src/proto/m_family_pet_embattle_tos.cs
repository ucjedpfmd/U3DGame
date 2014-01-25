namespace proto {
	public class m_family_pet_embattle_tos : Message
	{
		public int op_type = 0;
		public double fight_id = 0;
		public m_family_pet_embattle_tos() {
		}
		public override string getMethodName() {
			return "family_pet_embattle";
		}
		public override string getClassName() {
			return "m_family_pet_embattle_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"op_type", "int", "null"},new string[] {"fight_id", "double", "null"}};
		}
	}
}
