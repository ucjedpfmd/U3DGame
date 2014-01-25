namespace proto {
	public class p_pet_embattle_fight_info : Message
	{
		public double fight_id = 0;
		public p_pet_embattle_fight_member left_member = null;
		public p_pet_embattle_fight_member right_member = null;
		public object[] fight_records;
		public int result = 0;
		public int round = 0;
		public p_pet_embattle_fight_info() {
		}
		public override string getClassName() {
			return "p_pet_embattle_fight_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"fight_id", "double", "null"},new string[] {"left_member", "p_pet_embattle_fight_member", "null"},new string[] {"right_member", "p_pet_embattle_fight_member", "null"},new string[] {"fight_records", "array", "p_pet_embattle_fight_record"},new string[] {"result", "int", "null"},new string[] {"round", "int", "null"}};
		}
	}
}
