# Mercury
Speed up your lab deployments!

http://aka.ms/MercuryLabs is the production website.

## Inspiration
This project was inspired by Unfolding Lab, a lab deployment tool created by Brad Hughes, Brian Drepaul, and Matt Byrd.

## Development Framework
* Scrum framework
* 2-week sprints
* 1-hour sprint planning on Monday: create the sprint backlog (what items will be worked on)
* 15-minute daily scrum: dev team-only sync
* 1-hour sprint review 2nd Friday: discuss what features and items are done
* Sprint retrospective 2nd Friday: discuss progress and impediments, refine/expand the definition of done

## Development Guidelines
* Each product backlog item must:
 * Have an effort estimate
 * Have enough detail for the dev team to work with
 * Be sized to 1 sprint or less
* Operations
 * Production Web App continuously deploys from GitHub's master branch.
* Source code
 * Do not commit directly to master branch. Commit to the dev branch and then merge commits over to master branch.
 * Do not break the build! Check in only completed and working code.

## To start development:
1. Install Visual Studio 2015 Update 3 or higher
2. Install Azure SDK 2.9.6 or higher
3. Install Azure PowerShell module or CLI (optional)
4. Install Git (can be installed as part of VS)
5. Click this "Deploy to Azure" button to deploy an instance of this project to your Azure subscription.
[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)
6. Fork this repo.
7. Pull down the code using Visual Studio or Git.
8. Download the publish settings from your Azure Web App and import using VS.
9. Publish Web App to Azure using your downloaded publish settings.

## Feature Roadmap
- [ ] Lab creation
- [ ] Exchange 2013 support
- [ ] Exchange 2016 support
- [ ] SharePoint 2013 support
- [ ] SharePoint 2016 support
- [ ] Statistics tracking
- [ ] Accounts with historical view into labs
- [ ] ADFS integration
- [ ] Push integration with VMAS
- [ ] Push integration with Azure
- [ ] Push integration with Hyper-V
