namespace EnemySystem
{
    public abstract class ABaseClass
    {
         protected abstract  void Attack();

         public void TemplateAttack()
         {
             Attack();
         }
    }
}
