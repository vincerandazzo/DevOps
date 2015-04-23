Why do we want to do this?
I think ultimately its about getting enjoyment out of your work and being successful and happy with what we do.
Code deploys are hard.
So Devs are happy and don't want to kill Ops.  Build empathy.
So OPs are happy don't want to kill Devs. Build empathy.
I believe DevOps will be a skillset that companys pay people bugo bucks to do.  But remember DevOps is ultimately about PEOPLE first.  Or CULTURE first.  Its about people and culture so don't fool yourself. The tools are a by-product.  Lets get started!

Now I don't have an exact plan so we will be doing an agile methodology.

Objective:
-Deploy Johns bro's website from Dev(local machine) to AWS in as least amount of steps
-Learn flawless prod deploys
-Learn to build repeatable environment builds
-Infrastructure testing & validation
-Seamless flow between developers and ops


How?
-Use Kevin Days presentation as our guide.  This is from MeetUp at Lean Dog that I watched couple weeks back. https://speakerdeck.com/kday/introduction-to-ansible-from-playbook-to-production 
-Use Kevin Days Github project, we can probably just fork it and create our own with all our new changes.  Or start form scratch, not sure yet. https://github.com/kday/ansible-from-playbook-to-production 


First task:
-Create golden image in DEV using Packer, Vagrant, and VirtualBox